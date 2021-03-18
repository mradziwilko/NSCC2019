//
//  main.m
//  MyTime
//
//  Created by w0256451 on 2021-02-03.
//  Copyright © 2021 NSCC. All rights reserved.
//

#import <Foundation/Foundation.h>


int main(int argc, const char * argv[]) {
    @autoreleasepool {
        float floatValue;
        
        
        NSLog(@"Please enter a Time in Decimal format:");
        scanf("%f", &floatValue);
        
        
        float integerPortion = floor(floatValue);
        float decimalPortion = floatValue - integerPortion;

        NSString *timeString = [NSString stringWithFormat:@"%.0f hr. %.0f min", integerPortion, decimalPortion * 60];
        NSLog(@"Time: %@", timeString);
        
        
    }
    return 0;
}
