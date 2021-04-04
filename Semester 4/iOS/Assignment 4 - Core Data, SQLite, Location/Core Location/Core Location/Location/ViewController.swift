//
//  ViewController.swift
//  Location
//
//  Created by w0256451 on 2021-03-25.
//  Copyright © 2021 NSCC. All rights reserved.
//

import UIKit
import CoreLocation

class ViewController: UIViewController {
    
    
    @IBOutlet weak var txtLat: UILabel!
    @IBOutlet weak var txtLong: UILabel!
    @IBOutlet weak var Precision: UILabel!
    
    
    var locManager = CLLocationManager()
    var currentLocation: CLLocation!
    
    override func viewDidLoad() {
        super.viewDidLoad()
        locManager.requestWhenInUseAuthorization()
        locManager.desiredAccuracy = kCLLocationAccuracyBest
        locManager.distanceFilter = kCLDistanceFilterNone
        locManager.headingFilter = kCLHeadingFilterNone

        if
           CLLocationManager.authorizationStatus() == .authorizedWhenInUse ||
           CLLocationManager.authorizationStatus() ==  .authorizedAlways
        {
            currentLocation = locManager.location
        }
        
    }

    @IBAction func btnGetCoords(_ sender: Any) {
        
        txtLong.text = "\(currentLocation.coordinate.longitude)"
        txtLat.text = "\(currentLocation.coordinate.latitude)"
    
        
          Precision.text = "\(currentLocation.horizontalAccuracy as Any)"
    }
    
}

