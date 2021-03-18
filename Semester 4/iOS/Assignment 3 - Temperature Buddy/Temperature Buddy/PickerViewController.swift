//
//  PickerViewController.swift
//  Temperature Buddy
//
//  Created by w0256451 on 2021-03-05.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class PickerViewController: UIViewController {
    @IBOutlet weak var DatePicker: UIDatePicker!
    @IBOutlet weak var DateBtn: UIButton!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        DatePicker.setValue(UIColor.white, forKeyPath: "textColor")
        DatePicker.setValue(false, forKeyPath: "highlightsToday")

        // Do any additional setup after loading the view.
    }
    
    @IBAction func DateBtnAction(_ sender: Any) {
        let dateFormatter = DateFormatter()
                         dateFormatter.dateFormat = "yyyy-MM-dd"
                         
                         let controller = UIAlertController(title: "Date Selection", message: "Selected Date is " + dateFormatter.string(from: DatePicker.date), preferredStyle: .actionSheet);

                                                                 let dismissAction = UIAlertAction(title: "Dismiss", style: .cancel, handler: nil);
                                                           controller.addAction(dismissAction);

                                                               if let ppc = controller.popoverPresentationController {
                                                                ppc.sourceView = sender as? UIView;
                                                                ppc.sourceRect = (sender as AnyObject).bounds;
                                                               }

                                                               present(controller, animated: true, completion: nil);

    }


}
