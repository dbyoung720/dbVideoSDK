dbVideoSDK
=============

# dbVideoSDK 高速视频处理

- [English](readme.md)

## 一：特点：
	01、稳定；
	02、高效；基本没有性能损失。和硬件提供的性能一致；
	03、支持所有 DirectShow 视频输入设备；
	04、支持 x86、x64 平台；Win7、Win10 系统(Win11 下没有测试，应该可以正常工作)；
	05、支持视频预览、截图、图片叠加；
	06、支持高清截图(截图同时对图片进行降噪处理)；
	07、支持 MP4（H264）视频保存到文件；
	08、支持硬件加速 MP4 编码；支持 Intel 显卡硬件加速、Nvidia 显卡硬件加速；
	09、支持 RTMP 视频流推送；不耗 CPU 资源(启用硬件加速的情况下)；
	10、支持视频涂鸦。可以直接在视频上画图，然后 RTMP 推送出去(可以用于远程教学、会诊)；
	11、支持调整视频显示风格；如水平镜像、垂直镜像，等；
	12、支持虚拟桌面；
	13、支持人脸检测(只支持 x64 平台；需要 OpenCV4.6、CUDA11.7 SDK；使用 GPU 加速，不占用 CPU 资源。不影响帧率)；
	14、Intel  支持 MP4 编码的显卡必须是 630 或者以上；
	15、Nvidia 支持 MP4 编码的显卡必须是 GTX 1030 以上；
	<https://developer.nvidia.com/video-encode-and-decode-gpu-support-matrix-new>
    
## 二：示例：
	VC  : VC2022       目录：VC
	C#  : C#2022       目录：C#
	D11 : Delphi12     目录：D12

## 三：开发流程：
	01、初始化SDK：dbVideo_Init；
	02、获取视频设备列表：dbVideo_EnumVideoInputDevice；
	03、选取视频支持分辨率：dbVideo_EnumVideoFormat；
	04、开始视频预览：dbVideo_PreviewStart；
	05、截图(dbVideo_SnapBmp)、MP4录制(dbVideo_RecordMP4)、RTMP推流(dbVideo_LiveRTMP)，降噪(dbVideo_DeNoiseStyle)，等等操作......；
	06、停止视频预览：dbVideo_PreviewStop；
	07、SDK销毁：dbVideo_Free；

## 四：未来：
	1、支持人脸识别、人脸登记；
	2、支持车牌识别；

## 五：交流：
	1、邮件：dbyoung@sina.com
	2、QQ群：763103109
