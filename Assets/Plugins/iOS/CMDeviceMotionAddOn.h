//
//  CMDeviceMotionAddOn.h
//  IOSPlugin
//
//  Created by PGL on 10/20/15.
//  Copyright © 2015 PGL. All rights reserved.
//

#import <CoreMotion/CoreMotion.h>

@interface CMDeviceMotion (TransformToReferenceFrame)
-(CMAcceleration)userAccelerationInReferenceFrame;
-(CMAcceleration)userXInReferenceFrame;
@end

