



# et进阶

https://edu.uwa4d.com/course-intro/1/377?purchased=false



# et介绍

## 课程

[4｜ET框架前后端通讯初体验_【ET 6.0版本】ET框架 - C#全栈式网络游戏开发框架_UWA学堂 (uwa4d.com)](https://edu.uwa4d.com/lesson-detail/375/1514/1?isPreview=0)



Session类似一个手机



TChannel封装Socket,将回调push到主线程处理

## 游戏服务器架构

![image-20240116151910275](D:\UnityProject\ET\assets\image-20240116151910275.png)

### 为什么要增加Gate网关进程？

希望游戏服务器进程只关注业务处理，如果没有网关，服务器进程要管理大量socket连接，还要进行IO读写，效率低

游戏数据库代理进程也是取代之前服务器进程的工作

### 无缝地图架构

服务器进程之间可相互通信

![image-20240116152734909](D:\UnityProject\ET\assets\image-20240116152734909.png)



### 登录流程



Gate并不知道玩家在哪个地图，需要借助Location

![image-20240116153647204](D:\UnityProject\ET\assets\image-20240116153647204.png)

### 组件式架构

![image-20240116154238045](D:\UnityProject\ET\assets\image-20240116154238045.png)

![image-20240116154350629](D:\UnityProject\ET\assets\image-20240116154350629.png)

##  ECS

![image-20240116155243521](D:\UnityProject\ET\assets\image-20240116155243521.png)