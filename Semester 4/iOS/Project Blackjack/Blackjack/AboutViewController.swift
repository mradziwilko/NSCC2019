//
//  AboutViewController.swift
//  Blackjack
//
//  Created by Marshall Radziwilko on 2021-03-13.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit

class AboutViewController: UIViewController {

    override func viewDidLoad() {
        super.viewDidLoad()
    }
    
    // Back to Title screen
    @IBAction func BackBtn(_ sender: Any) {
        self.tabBarController?.selectedIndex = 0
    }
    
}
