using System;
using System.Runtime.InteropServices;
using UnityEngine;


namespace LocationTracking
{
	public struct Quaternion4f{
		public float x;
		public float y;
		public float z;
		public float w;
	}
	
	public struct Vector3f{
		public float x;
		public float y;
		public float z;
	}

	public enum State{
		STOP = 0,
		TURNING = 1,
		ACCELERATING = 2,
		DEACCELERATING = 3
	}

	public class IOSPlugin
	{

		[DllImport ("__Internal")]
		public static extern void _InitSensor();
		[DllImport ("__Internal")]
		public static extern void _StartSensorData();
		[DllImport ("__Internal")]
		public static extern void _StopSensorData();
		[DllImport ("__Internal")]
		public static extern Vector3f _GetPosition ();
		[DllImport ("__Internal")]
		public static extern Quaternion4f _GetAttitude ();
		[DllImport ("__Internal")]
		public static extern State _GetState ();
		[DllImport ("__Internal")]
		public static extern State _Calibration (Vector3f v);
		
		public static void UnityInitSensor(){
			_InitSensor ();
		}
		
		public static void UnityStartSensorData(){
			_StartSensorData ();
		}
		
		public static void UnityStopSensorData(){
			_StopSensorData ();
		}
		
		public static Vector3 UnityGetPosition(){
			Vector3f posTemp = _GetPosition ();
			Vector3 pos;
			pos.x = posTemp.x;
			pos.y = posTemp.y;
			pos.z = posTemp.z;
			return pos;
		}

		public static Quaternion UnityGetAttitude(){
			Quaternion4f attTemp = _GetAttitude ();
			Quaternion atti;
			atti.x = attTemp.x;
			atti.y = attTemp.y;
			atti.z = attTemp.z;
			atti.w = attTemp.w;
			return atti;
		}

		public static String UnityGetState(){
			switch(_GetState()){
			case State.STOP:
				return "STOP";
			case State.TURNING:
				return "TURNING";
			case State.ACCELERATING:
				return "ACCELERATION";
			case State.DEACCELERATING:
				return "DECELERATION";
			default:
				return "UNKNOWN";
			}
		}

		public static void Calibration(Vector3 pos){
			Vector3f pos1;
			pos1.x = pos.x;
			pos1.y = pos.y;
			pos1.z = pos.z;
			_Calibration (pos1);
		}
	}

}

