//
//  SliderViewController.swift
//  Temperature Buddy
//
//  Created by w0256451 on 2021-03-05.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class SliderViewController: UIViewController {

    @IBOutlet weak var Slider: UISlider!
    @IBOutlet weak var SlidTxt: UILabel!
    
    override func viewDidLoad() {
        super.viewDidLoad()

        // Do any additional setup after loading the view.
    }
    
    @IBAction func ActSlider(_ sender: Any) {
        SlidTxt.text = "\(lroundf(Slider.value))";
    }
    

}
