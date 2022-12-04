dbVideoSDK
=============

# dbVideoSDK High speed video processing

- [中文](readmeCN.md)

## 一：Content：
	01、Stable；
	02、Efficient；Basically no performance loss. Consistent with the performance provided by hardware；
	03、Supports all DirectShow video input devices；
	04、Supports x86、x64 platform；Win7、Win10 OS；
	05、Support video preview, snap and image overlay；
	06、Support HD snap(Screenshot and noise reduction)；
	07、Support MP4 (H264) video save to files；
	08、Support hardware accelerated MP4 coding; Support Intel and Nvidia graphics cards；
	09、Support RTMP video streaming; No CPU consumption (with hardware acceleration enabled)；
	10、Support video graffiti. You can draw pictures directly on the video, and then push them out by RTMP (which can be used for remote teaching and consultation)；
	11、Support adjusting video display style; Such as horizontal mirror image, vertical mirror image, etc；
	12、Support virtual desktop；
  13：Intel  Supporting MP4 encoding must be 630 or above；
  14：Nvidia Supporting MP4 encoding must be GTX 1030 above；
  <https://developer.nvidia.com/video-encode-and-decode-gpu-support-matrix-new>

## 二：DEMO：
	VC  : VC2022       Path：VC
	C#  : C#2022       Path：C#
	D11 : Delphi10.4.2 Path：D10

## 三：Development：
	01、Video SDK Init：dbVideo_Init；
	02、Get video device list：dbVideo_EnumVideoInputDevice；
	03、Get video support resolution：dbVideo_EnumVideoFormat；
	04、Start video preview：dbVideo_PreviewStart；
	05、Snap(dbVideo_SnapBmp)、MP4 record(dbVideo_RecordMP4)、RTMP live(dbVideo_LiveRTMP)，And so on......；
	06、Stop video preview：dbVideo_PreviewStop；
	07、Video SDK Free：dbVideo_Free；

## 四：Future：
	1、Support face detection, face recognition and face registration；
	2、Support license plate recognition；
