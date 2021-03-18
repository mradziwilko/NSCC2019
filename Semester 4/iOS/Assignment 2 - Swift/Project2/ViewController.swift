//
//  ViewController.swift
//  Project2
//
//  Created by w0256451 on 2021-02-19.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class ViewController: UIViewController {

    @IBOutlet weak var Check1: UIImageView!
    @IBOutlet weak var Check2: UIImageView!
    @IBOutlet weak var Check3: UIImageView!
    @IBOutlet weak var Switch1: UISwitch!
    @IBOutlet weak var Switch2: UISwitch!
    @IBOutlet weak var Switch3: UISwitch!
    @IBOutlet weak var txtNumber: UILabel!
    @IBOutlet weak var Slider: UISlider!
    @IBOutlet weak var DatePick: UIDatePicker!
    @IBOutlet weak var BottomBar: UISegmentedControl!
    @IBOutlet weak var ChkBtn: UIButton!
    
    
    override func viewDidLoad() {
        super.viewDidLoad()

        
        txtNumber.isHidden = true;
        Slider.isHidden = true;
        DatePick.isHidden = true;
        Switch2.isOn = false;
        Switch3.isOn = false;
        
    }


    @IBAction func ActionSwitch1(_ sender: UISwitch) {
        if(Switch1.isOn) {
            
            Check1.image = UIImage(named: "chk1");
            
        }else{
            
            Check1.image = UIImage(named: "blank");
            
        }
    }
    
    
    @IBAction func ActionSwitch2(_ sender: UISwitch) {
        
        if(Switch2.isOn) {
            Check2.image = UIImage(named: "chk2");
        }else{
            
            Check2.image = UIImage(named: "blank");
            
        }
        
    }
    
    @IBAction func ActionSwitch3(_ sender: UISwitch) {
        
        if(Switch3.isOn) {
            Check3.image = UIImage(named: "chk3");
        }else{
            Check3.image = UIImage(named: "blank");
            
        }    }
    
    @IBAction func BottomBar(_ sender: UISegmentedControl) {
       
        switch sender.selectedSegmentIndex {
         
            case 0:
                
                Check1.isHidden = false;
                Check2.isHidden = false;
                Check3.isHidden = false;
                Switch1.isHidden = false;
                Switch2.isHidden = false;
                Switch3.isHidden = false;
                txtNumber.isHidden = true;
                Slider.isHidden = true;
                DatePick.isHidden = true;
                ChkBtn.setTitle("Check Images", for: .normal);

            break;
            
            case 1:
            Check1.isHidden = true;
            Check2.isHidden = true;
            Check3.isHidden = true;
            Switch1.isHidden = true;
            Switch2.isHidden = true;
            Switch3.isHidden = true;
            txtNumber.isHidden = false;
            Slider.isHidden = false;
            DatePick.isHidden = true;
            ChkBtn.setTitle("Check Slider Number", for: .normal);
            
            break;
            
            case 2:
            Check1.isHidden = true;
            Check2.isHidden = true;
            Check3.isHidden = true;
            Switch1.isHidden = true;
            Switch2.isHidden = true;
            Switch3.isHidden = true;
            txtNumber.isHidden = true;
            Slider.isHidden = true;
            DatePick.isHidden = false;
            txtNumber.text = "\(lroundf(Slider.value))";
            ChkBtn.setTitle("Check Date Selected", for: .normal);
            
            break;
           default:
           
           Check1.isHidden = false;
           Check2.isHidden = false;
           Check3.isHidden = false;
           Switch1.isHidden = false;
           Switch2.isHidden = false;
           Switch3.isHidden = false;
           txtNumber.isHidden = true;
           Slider.isHidden = true;
           DatePick.isHidden = true;
            break;
            
        }
        
        
    }
    
    @IBAction func ChkBtn(_ sender: UIButton) {
      
        
        
              switch BottomBar.selectedSegmentIndex {
               
                  case 0:
                  var msgSTR1 = "Off";
                  var msgSTR2 = "Off";
                  var msgSTR3 = "Off";
                  var msgSTR4 = "Off";
                  var msgSTR5 = "Off";
                  var msgSTR6 = "Off";
                    
                    if(Switch1.isOn) {
                        msgSTR1 = " On";
                        msgSTR4 = " On";
                    }
                    if(Switch2.isOn) {
                        msgSTR2 = " On";
                        msgSTR5 = " On";
                        
                    }
                    if(Switch3.isOn) {
                        msgSTR3 = " On";
                        msgSTR6 = " On";
                        
                    }
                  
                    let controller = UIAlertController(title: "ActionSheet", message: "Switch 1:" + msgSTR1 + " Image 1:" + msgSTR4 + ", Switch 2:" + msgSTR2 + " Image 2:" + msgSTR5 + ", Switch 3:" + msgSTR3 + " Image 3:" + msgSTR6, preferredStyle: .actionSheet);

                                let dismissAction = UIAlertAction(title: "Dismiss", style: .cancel, handler: nil);
                          controller.addAction(dismissAction);

                              if let ppc = controller.popoverPresentationController {
                                  ppc.sourceView = sender;
                                  ppc.sourceRect = sender.bounds;
                              }

                              present(controller, animated: true, completion: nil);
                      
                  break;
                  
                  case 1:
                    let controller = UIAlertController(title: "ActionSheet", message: "Value of Slider is " + "\(lroundf(Slider.value))", preferredStyle: .actionSheet);

                                             let dismissAction = UIAlertAction(title: "Dismiss", style: .cancel, handler: nil);
                                       controller.addAction(dismissAction);

                                           if let ppc = controller.popoverPresentationController {
                                               ppc.sourceView = sender;
                                               ppc.sourceRect = sender.bounds;
                                           }

                                           present(controller, animated: true, completion: nil);
                    
                  break;
                  
                  case 2:

                    let dateFormatter = DateFormatter()
                    dateFormatter.dateFormat = "yyyy-MM-dd"
                    
                    let controller = UIAlertController(title: "ActionSheet", message: "Selected Date is " + dateFormatter.string(from: DatePick.date), preferredStyle: .actionSheet);

                                                            let dismissAction = UIAlertAction(title: "Dismiss", style: .cancel, handler: nil);
                                                      controller.addAction(dismissAction);

                                                          if let ppc = controller.popoverPresentationController {
                                                              ppc.sourceView = sender;
                                                              ppc.sourceRect = sender.bounds;
                                                          }

                                                          present(controller, animated: true, completion: nil);
                                   
                    
                  break;
                 default:
                 
               
                    
                  break;
                  
              }

    }
    
    
    @IBAction func Slider(_ sender: UISlider) {

        txtNumber.text = "\(lroundf(sender.value))";
        
    }
    
    @IBAction func DatePicker(_ sender: UIDatePicker) {
    }
    
}

