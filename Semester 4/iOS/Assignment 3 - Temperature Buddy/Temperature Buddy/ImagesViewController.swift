//
//  ImagesViewController.swift
//  Temperature Buddy
//
//  Created by w0256451 on 2021-03-05.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class ImagesViewController: UIViewController {

    @IBOutlet weak var Swi1: UISwitch!
    @IBOutlet weak var Swi2: UISwitch!
    @IBOutlet weak var Swi3: UISwitch!
    @IBOutlet weak var Img1: UIImageView!
    @IBOutlet weak var Img2: UIImageView!
    @IBOutlet weak var Img3: UIImageView!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        
    }
    
    @IBAction func SwiAct1(_ sender: Any) {
       if(Swi1.isOn) {
            Img1.image = UIImage(named: "chk1");
       }else{
            Img1.image = UIImage(named: "blank");
        }
    }
    
    @IBAction func SwiAct2(_ sender: Any) {
        if(Swi2.isOn) {
            Img2.image = UIImage(named: "chk2");
        }else{
            Img2.image = UIImage(named: "blank");
        }
    }
    
    @IBAction func SwiAct3(_ sender: Any) {
        if(Swi3.isOn) {
            Img3.image = UIImage(named: "chk3");
        }else{
            Img3.image = UIImage(named: "blank");
        }

    }
    

}
