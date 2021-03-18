//
//  main.m
//  CircleArea
//
//  Created by w0256451 on 2021-02-03.
//  Copyright © 2021 NSCC. All rights reserved.
//

#import <Foundation/Foundation.h>
    @interface Circle : NSObject
        -(void) setRadius: (float) n;
        -(float) getRadius;
        -(double) computeDiameter;
        -(double) computeArea;
        -(void) Display;
    @end

    @implementation Circle {
        float Radius;
    }

    -(void) setRadius: (float) n {
        Radius = n;
    }

    -(float) getRadius {
        return Radius;
    }

    -(double) computeDiameter {
        
        return 3.14 * Radius * Radius;
        
    }

    -(double) computeArea {
        
        
        return Radius * 2;
    }

    -(void) Display {
        NSLog(@"A Circle with the Radius of %.2f  has a Area of %.2f and a Diamiter of %.2f.", Radius, [self computeArea], [self computeDiameter]);
        
    }


@end



int main(int argc, const char * argv[]) {
    @autoreleasepool {
        Circle *myCircle = [[Circle alloc] init];
        
        float floatValue;
        NSLog(@"Enter the Radius of the Circle:");
        scanf("%f", &floatValue);
        
        [myCircle setRadius:floatValue];
        [myCircle Display];
        
    }
    return 0;
}
