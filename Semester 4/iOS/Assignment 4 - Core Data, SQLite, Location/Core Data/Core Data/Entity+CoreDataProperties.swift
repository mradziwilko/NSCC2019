//
//  Entity+CoreDataProperties.swift
//  Core Data
//
//  Created by w0256451 on 2021-04-04.
//  Copyright © 2021 NSCC. All rights reserved.
//
//

import Foundation
import CoreData


extension Entity {

    @nonobjc public class func fetchRequest() -> NSFetchRequest<Entity> {
        return NSFetchRequest<Entity>(entityName: "Entity")
    }

    @NSManaged public var name: String?

}
