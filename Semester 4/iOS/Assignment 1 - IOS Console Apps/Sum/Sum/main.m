//
//  main.m
//  Sum
//
//  Created by w0256451 on 2021-02-04.
//  Copyright © 2021 NSCC. All rights reserved.
//

#import <Foundation/Foundation.h>

int main(int argc, const char * argv[]) {
    @autoreleasepool {
        int number,digit,sum=0, temp;
        
               NSLog(@"Enter a number:");
               scanf("%i", &number);
               temp = number;
                
               while(temp > 0) {
                   digit = temp%10;
                   if (digit % 2) {
                       sum += digit;
                   }
                   temp = temp/10;
               }
        
               NSLog(@"Odd Number Sum of %i is = %i",number,sum);
    }
    return 0;
}
