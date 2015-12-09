//
//  IOSPlugin.h
//  IOSPlugin
//
//  Created by PGL on 10/21/15.
//  Copyright © 2015 PGL. All rights reserved.
//

#import <Foundation/Foundation.h>
#import <CoreMotion/CoreMotion.h>
#import <UIKit/UIKit.h>
#import <GLKit/GLKit.h>
#import "Motion.h"

@interface IOSPlugin : NSObject
@end

typedef NS_ENUM(NSInteger,State) {
    STOP = 0,
    TURNING = 1,
    ACCELERATING = 2,
    DEACCELERATING = 3
};
static State state;

static Motion *motion1;
static Motion *motion2;
static Motion *motion3;

static float accMaxTime;
static float accMinTime;
static float stopTime;

static CMMotionManager*		myMotionManager	= nil;
static NSOperationQueue*	myMotionQueue	= nil;

static const float myUserUpdateInterval = 1.0f / 60.0f;

extern "C" {
    
    struct Vector3f{
        float x;
        float y;
        float z;
    };
    
    struct Quaternion4f{
        float x;
        float y;
        float z;
        float w;
    };
    
    /// Initialize Sensor Data
    void _InitSensor();
    
    /// Streaming Sensor Data
    void _StartSensorData();
    
    /// Calibration
    void _Calibration();
    
    ///Stop Sensor Data
    void _StopSensorData();

    Vector3f _GetPosition();
    
    Quaternion4f _GetAttitude();
}

void InitSensor();

/// Streaming Sensor Data
void StartSensorData();

/// Calibration
void Calibration();

///Stop Sensor Data
void StopSensorData();

GLKVector3 GetPosition();

CMQuaternion GetAttitude();