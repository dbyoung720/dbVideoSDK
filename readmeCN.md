dbVideoSDK
=============

# dbVideoSDK 高速视频处理

- [English](readme.md)

## 一：特点：
	01、稳定；
	02、高效；基本没有性能损失。和硬件提供的性能一致；
	03、支持所有 DirectShow 视频输入设备；
	04、支持 x86、x64 平台；Win7、Win10 系统；
	05、支持视频预览、截图、图片叠加；
	06、支持高清截图(截图同时对图片进行降噪处理)；
	07、支持 MP4（H264）视频保存到文件；
	08、支持硬件加速 MP4 编码；支持 Intel、Nvidia 显卡；
	09、支持 RTMP 视频流推送；不耗 CPU 资源(启用硬件加速的情况下)；
	10、支持视频涂鸦。可以直接在视频上画图，然后 RTMP 推送出去(可以用于远程教学、会诊)；
	11、支持调整视频显示风格；如水平镜像、垂直镜像，等；
	12、支持虚拟桌面；

## 二：示例：
	VC  : VC2022       目录：VC
	C#  : C#2022       目录：C#
	D11 : Delphi10.4.2 目录：D10

## 三：开发流程：
	01、初始化SDK：dbVideo_Init；
	02、获取视频设备列表：dbVideo_EnumVideoInputDevice；
	03、选取视频支持分辨率：dbVideo_EnumVideoFormat；
	04、开始视频预览：dbVideo_PreviewStart；
	05、截图(dbVideo_SnapBmp)、MP4录制(dbVideo_RecordMP4)、RTMP推流(dbVideo_LiveRTMP)，等等操作......；
	06、停止视频预览：dbVideo_PreviewStop；
	07、SDK销毁：dbVideo_Free；

## 四：未来：
	1、支持人脸检测、人脸识别、人脸登记；
	2、支持车牌识别；
