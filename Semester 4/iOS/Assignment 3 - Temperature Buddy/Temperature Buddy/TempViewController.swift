//
//  TempViewController.swift
//  Temperature Buddy
//
//  Created by w0256451 on 2021-03-05.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class TempViewController: UIViewController {
    
    @IBOutlet weak var inpNumber: UITextField!
    @IBOutlet weak var tempChk: UISwitch!
    @IBOutlet weak var lblF: UILabel!
    @IBOutlet weak var lblC: UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        
        
        
    }
    
    func calculateCelsius(fahrenheit: Double) -> Double {
        var celsius: Double
        
        celsius = (fahrenheit - 32) * 5 / 9
        
        return celsius
    }

    func calculateFahrenheit(celsius: Double) -> Double {
        var fahrenheit: Double
        
        fahrenheit = celsius * 9 / 5 + 32
        
        return fahrenheit
    }
    func textField(_ textField: UITextField, shouldChangeCharactersIn range: NSRange, replacementString string: String) -> Bool {
        let allowedCharacters = CharacterSet.decimalDigits
        let characterSet = CharacterSet(charactersIn: string)
        return allowedCharacters.isSuperset(of: characterSet)
    }
    @IBAction func SwitchTemp(_ sender: Any) {
        
        if(tempChk.isOn) {
            lblF.textColor = UIColor.red
            lblC.textColor = UIColor.white
             }else{
                 lblF.textColor = UIColor.white
                 lblC.textColor = UIColor.red
                 
        }
    }
    
    @IBAction func ConvertBtn(_ sender: Any) {
        
        if let text = inpNumber.text, !text.isEmpty {
                
            
            let InpNumber: String = inpNumber.text!
            
            let convNumb: Double = Double(InpNumber) as! Double
            let message: String
            let title: String
            let TempConv: String
            
           if(tempChk.isOn) {
            let Converterted: Double = calculateFahrenheit(celsius: convNumb);
           TempConv =  String(format: "%.0f", Converterted)
            message = TempConv + "\u{00B0}f"
            title = "Converted to Fehrenheit"
                }else{
            
            let Converterted: Double = calculateCelsius(fahrenheit: convNumb);
            TempConv =  String(format: "%.0f", Converterted)
            message = TempConv + "\u{00B0}c"
            title = "Converted to Celsius"
                 }
            

            
            let controller = UIAlertController(title: title, message: message, preferredStyle: .actionSheet);

                                                                      let dismissAction = UIAlertAction(title: "Dismiss", style: .cancel, handler: nil);
                                                                controller.addAction(dismissAction);

                                                                    if let ppc = controller.popoverPresentationController {
                                                                     ppc.sourceView = sender as? UIView;
                                                                     ppc.sourceRect = (sender as AnyObject).bounds;
                                                                    }

                                                                    present(controller, animated: true, completion: nil);

            
            
               } else {

                   let controller = UIAlertController(title: "Error", message: "Number Cannot be Empty", preferredStyle: .actionSheet);

                                                           let dismissAction = UIAlertAction(title: "Dismiss", style: .cancel, handler: nil);
                                                     controller.addAction(dismissAction);

                                                         if let ppc = controller.popoverPresentationController {
                                                          ppc.sourceView = sender as? UIView;
                                                          ppc.sourceRect = (sender as AnyObject).bounds;
                                                         }

                                                         present(controller, animated: true, completion: nil);

               
                   
               }
        
        
    }
    
}
