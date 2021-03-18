//
//  TitleViewController.swift
//  Blackjack
//
//  Created by Marshall Radziwilko on 2021-03-13.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class TitleViewController: UIViewController {
  
    @IBOutlet weak var PlayerName: UILabel!
    
    
    // Saved Variables
    let Player = Configuration.value(defaultValue: "NoPlayer", forKey: "playername")

    
    // Set Player name, if no name set to NoPlayer
    override func viewDidLoad() {
        super.viewDidLoad()
        PlayerName.text = (Player)
    }
    
    // Start New Game, if Player name is Empty, or Set to "NoPlayer" ask for new Player Name, if all is good go to Tab Game (1)
    @IBAction func NewGame(_ sender: Any) {
        if(Player.isEmpty) {
            showInputDialog(true)
        }else if(Player == "NoPlayer") {
            showInputDialog(true)
        } else {
           self.tabBarController?.selectedIndex = 1
        }
        
    }
    
    // Go to About View
    @IBAction func AboutWindow(_ sender: Any) {
        self.tabBarController?.selectedIndex = 2
    }
    
    
    // Input Dialog for Player Name
    func showInputDialog(_ animated: Bool) {
           let alert = UIAlertController(title: "Enter Name", message: "Please Enter your Name", preferredStyle: .alert)
           alert.addTextField { (textField) in
               textField.placeholder = "Default placeholder text"
           }

           alert.addAction(UIAlertAction(title: "Submit", style: .default, handler: { [weak alert] (_) in
               guard let textField = alert?.textFields?[0], let userText = textField.text else { return }
            
            // Set Default variables Player Name - 500 goins to start
               Configuration.value(value: userText, forKey: "playername")
               Configuration.value(value: 500, forKey: "coins")
            
            self.PlayerName.text = userText
           }))

           self.present(alert, animated: true, completion: nil)
       }

}


// Configuration for Saved Prefrences
class Configuration {

    static func value<T>(defaultValue: T, forKey key: String) -> T{

        let preferences = UserDefaults.standard
        return preferences.object(forKey: key) == nil ? defaultValue : preferences.object(forKey: key) as! T
    }

    static func value(value: Any, forKey key: String){

        UserDefaults.standard.set(value, forKey: key)
    }

}
