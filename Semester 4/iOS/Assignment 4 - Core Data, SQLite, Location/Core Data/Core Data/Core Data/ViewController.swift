//
//  ViewController.swift
//  Core Data
//
//  Created by w0256451 on 2021-04-04.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit
import CoreData

class ViewController: UIViewController {

    // Base Outlets
    @IBOutlet weak var inpInfo: UITextField!
    @IBOutlet weak var txtInfo: UILabel!
    
    // Variables for App
    var dbval: [Entity]?
    let context = (UIApplication.shared.delegate as! AppDelegate).persistentContainer.viewContext
       
    // Main Function
    override func viewDidLoad() {
        super.viewDidLoad()
        
        // Create Fetch Request
        let fetchRequest = NSFetchRequest<NSManagedObject>(entityName: "Entity");
        
        // Set Request to Feild "Name" from Core Data
        fetchRequest.sortDescriptors = [NSSortDescriptor(key: "name", ascending: true)]
        
        // When starting, fetch previous Value from Storage
        do {
            // Fetch Data from Database
            self.dbval = try context.fetch(Entity.fetchRequest())
            // Set Textbox
            GetInputfromDatabase()
        }catch {}
    }

    @IBAction func btnSaveRet(_ sender: Any) {
        // Set New Value to Database, then retreive it.
        SetDatabaseEntry() // Set Values to Database
        GetInputfromDatabase() // Set Textbox from Database
    }
    
    // Get Data from Core Data, and Input into Label
    func GetInputfromDatabase()
    {
            do {
                self.dbval = try context.fetch(Entity.fetchRequest())
                DispatchQueue.main.async
                {
                    for i in 0..<self.dbval!.count
                    {
                        // For each value in the Database set txtbox Info with string.
                        let str = self.dbval![i].name
                        self.txtInfo.text = str
                    }
                }
            }catch{}
    }
    
    
    // Get Text from "TextBox" and Input Value into Database.
    func SetDatabaseEntry()
    {
        //
       let inpTxt = inpInfo.text
       let newString = Entity(context: self.context)
       newString.name = inpTxt
       do{
            try self.context.save()
       }catch{}
    }
}
