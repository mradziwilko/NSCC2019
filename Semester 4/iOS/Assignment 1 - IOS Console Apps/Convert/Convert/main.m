//
//  main.m
//  Convert
//
//  Created by w0256451 on 2021-02-04.
//  Copyright © 2021 NSCC. All rights reserved.
//

#import <Foundation/Foundation.h>
#include <stdlib.h>
 @interface Conversions : NSObject
    -(void) setNumber: (float) n;
    -(double) toMiles;
    -(double) toKilometers;
    -(double) toKilograms;
    -(double) toPounds;
    -(double) toInches;
    -(double) toCentimeters;
    -(double) toCAN;
    -(double) toUSD;
    -(void) DisplayToMiles;
    -(void) DisplayToKilom;
    -(void) DisplayToKilog;
    -(void) DisplayToPoun;
    -(void) DisplayToInch;
    -(void) DisplayToCent;
    -(void) DisplayToCan;
    -(void) DisplayToUsd;
 @end

    @implementation Conversions {
        float Number;
    }

    -(void) setNumber: (float) n {
        Number = n;
    }

    -(double) toMiles {
        return Number / 0.621371192;
    }

    -(double) toKilometers {
        return Number / 1000.00;
    }

    -(double) toKilograms {
        return Number * 0.45359237;
    }
    -(double) toPounds {
        return Number * 2.20462;
    }
    -(double) toInches {
        return 0.3937 * Number;
    }
    -(double) toCentimeters {
        return 2.54 * Number;
    }
    -(double) toCAN {
        return Number * 0.78;
    }
    -(double) toUSD {
        return Number * 1.28;
    }

    -(void) DisplayToMiles{
        NSLog(@"Converted Kilometer: %.2f to Miles is: %.2f.", Number,  [self toMiles]);
    }

    -(void) DisplayToKilom{
        NSLog(@"Converted Miles: %.2f to Kilometer is: %.2f.", Number,  [self toKilometers]);
        
    }

    -(void) DisplayToKilog{
        NSLog(@"Converted Pounds: %.2f to Kilogram is: %.2f.", Number,  [self toKilograms]);
        
    }

    -(void) DisplayToPoun{
        NSLog(@"Converted Kilogram: %.2f to Pounds is: %.2f.", Number,  [self toPounds]);
        
    }

    -(void) DisplayToInch{
        NSLog(@"Converted Centimeter: %.2f to Inches is: %.2f.", Number,  [self toInches]);
        
    }

    -(void) DisplayToCent{
        NSLog(@"Converted Inch: %.2f to Centimeter is: %.2f.", Number,  [self toCentimeters]);
        
    }

    -(void) DisplayToCan{
        NSLog(@"Converted United States Dollar: %.2f to Canadian Dollar is: %.2f.", Number,  [self toCAN]);
        
    }

    -(void) DisplayToUsd{
        NSLog(@"Converted Canadian Dollar : %.2f to United States Dollar  is: %.2f.", Number,  [self toUSD]);
        
    }

    
@end



int main(int argc, const char * argv[]) {
    @autoreleasepool {
        Conversions *myConversion = [[Conversions alloc] init];
        int Choice = 0;
        float Number;
        while(Choice != 9) {
            NSLog(@"---------------------------------------------------------------------------");
            NSLog(@"           Menu");
            NSLog(@"---------------------------------------------------------------------------");
            NSLog(@"#1 - Kilometers to Miles");
            NSLog(@"#2 - Miles to Kilometers");
            NSLog(@"#3 - Kilograms to Pounds");
            NSLog(@"#4 - Pounds to Kilograms");
            NSLog(@"#5 - Centimeter to Inches");
            NSLog(@"#6 - Inches to Centimeter");
            NSLog(@"#7 - US Dollar to Canadian Dollar");
            NSLog(@"#8 - Canadian Dollar to US Dollar");
            NSLog(@"#9 - Exit");
            NSLog(@"---------------------------------------------------------------------------");
            NSLog(@"Enter a Choice:");
            NSLog(@"---------------------------------------------------------------------------");
            scanf ("%d", &Choice);
            
            
            
            switch (Choice) {
                    
                    case 1:
                    NSLog(@"---------------------------------------------------------------------------");
                    NSLog(@"Please Enter a Number to convert from:");
                    NSLog(@"---------------------------------------------------------------------------");
                    scanf ("%f", &Number);
                    NSLog(@"---------------------------------------------------------------------------");
                    [myConversion setNumber:Number];
                    [myConversion DisplayToMiles];
                    NSLog(@"---------------------------------------------------------------------------");
                    NSLog(@" ");
                    break;

                    case 2:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToKilom];
                    break;
                
                    case 3:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToPoun];
                    break;
                    
                    case 4:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToKilog];
                    break;
                    case 5:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToInch];
                    
                    break;
                    case 6:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToCent];
                    break;
                    case 7:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToCan];
                    break;
                    case 8:
                    NSLog(@"Please Enter a Number to convert from:");
                    scanf ("%f", &Number);
                    [myConversion setNumber:Number];
                    [myConversion DisplayToUsd];
                    break;
                    default:
                    NSLog(@"Error: Invalid Choice.");
                    break;
            }
            
        }
        
    }
    return 0;
}
