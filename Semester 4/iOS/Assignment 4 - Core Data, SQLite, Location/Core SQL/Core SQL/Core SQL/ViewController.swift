//
//  ViewController.swift
//  Core SQL
//
//  Created by w0256451 on 2021-04-04.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit
import SQLite3

class ViewController: UIViewController {

    
    // Outlets
    @IBOutlet weak var inpValue: UITextField!
    @IBOutlet weak var txtOutput: UILabel!
    
    
    var db: OpaquePointer?
    
    
    // Dear Darren, Please note that I did not use Error outputs, wasnt required, Please if you see SQLITE_OK{} Will be Error / Sucess between {}
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        
        // Create the SQLite File and Create its first Database if no Database "UserData" exists.
        let fileUrl = try!
        FileManager.default.url(for: .documentDirectory, in: .userDomainMask, appropriateFor: nil, create: false).appendingPathComponent("UserData.sqlite")
        
        
        // Open Database if Exists
        if sqlite3_open(fileUrl.path, &db) != SQLITE_OK{}
        
        // Create Database if does not exist.
        if sqlite3_exec(db, "CREATE TABLE IF NOT EXISTS UserData (id INTEGER PRIMARY KEY AUTOINCREMENT, Name text)", nil, nil, nil) != SQLITE_OK{}
        
        
        // Read Values if exists, if not Text Label will be defalt message
        readValues()
    }

    @IBAction func btnSaveFetch(_ sender: UIButton) {

            let inpData = inpValue.text?.trimmingCharacters(in: .whitespacesAndNewlines)
            
            // if Input is Empty show Alert.
            if (inpData?.isEmpty)!{
                let alert = UIAlertController(title: "Error", message: "Input is Empty.", preferredStyle: UIAlertController.Style.alert)
                alert.addAction(UIAlertAction(title: "Dismiss", style: UIAlertAction.Style.default, handler: nil))
                self.present(alert, animated: true, completion: nil)
                return;
            }
            
            var stmt: OpaquePointer?
            // Insert Input into Field Name.
            if sqlite3_prepare(db, "INSERT INTO UserData (Name) VALUES (?)", -1, &stmt, nil) != SQLITE_OK{}
            // Bind to Sql Statement
            if sqlite3_bind_text(stmt, 1, inpData, -1, nil) != SQLITE_OK{}
            // Execute Statement
            if sqlite3_step(stmt) == SQLITE_DONE{}
            
            // Read Current Values and input into Label
            readValues()
    }
    
    func readValues(){
            var stmt:OpaquePointer?
            // Prepair statement, Fetch Data from UserData Table.
            if sqlite3_prepare(db, "SELECT * FROM UserData", -1, &stmt, nil) != SQLITE_OK{return;}
    
            // Fetch value Statement and put into Label
            while(sqlite3_step(stmt) == SQLITE_ROW){
                let retData = String(cString: sqlite3_column_text(stmt, 1))
                txtOutput.text = retData
            }
       }
}

