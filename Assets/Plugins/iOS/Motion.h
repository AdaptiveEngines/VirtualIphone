//
//  Motion.h
//  IOSPlugin
//
//  Created by PGL on 10/28/15.
//  Copyright © 2015 PGL. All rights reserved.
//

//#import <Foundation/Foundation.h>
//#import <CoreMotion/CoreMotion.h>
#import <GLKit/GLKit.h>

#import "CMDeviceMotionAddOn.h"


@interface Motion:NSObject

@property float timeStamp;
@property GLKVector3 acceleration;
@property GLKVector3 velocity;
@property GLKVector3 position;
@property CMQuaternion attitude;
@property GLKVector3 xdirection;
@property GLKVector3 angularVel;
- (id) init;
- (void) assign:(CMDeviceMotion *)dmData;
- (void) copy:(Motion *) copyMotion;
- (bool) accTooSmall;
- (bool) angularVelTooBig;
- (void) integrateAcc:(Motion *)lastMotion;
- (void) integrateVel:(Motion *)lastMotion;
@end