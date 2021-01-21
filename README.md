# XQColorful

### 介绍

XQColorful是重新设计的XQSDK for c#. 目的在于简化之前繁琐的封装，让整体架构更加轻盈，且更容易调试与移植开发。 

### 安装教程

目前一共推荐两种开发包部署方式

##### XQC-CLI
XQC-CLI是用来快速部署开发包并调整项目属性的工具。
你可以在 Release 发行页面下载最新的XQC-CLI 或者 [点击这里](https://gitee.com/heerkaisair/xqcolorful/attach_files/593308/download/XQC-CLI.exe)

下载XQC-CLI后，将其放置于文件夹内，并打开命令行，输入

```
xqc-cli 插件名 插件作者
```
XQC-CLI会从Git Clone 并 修改程序集信息 修改文件夹名等步骤，将开发包修改为以插件名为主体的开发包（防止Fody打包后XQ插件运行时因为某些程序集重复载入失败）

#### 直接下载源码包

这种方式需要你自行创建一个解决方案 创建类库项目 插件名.Core 和 插件名.SDK 并将源码包对应的 packages.config 和 代码cs文件 移入项目文件夹下。

等待还原Nuget包后即可开始编码环节。

### 推荐开发

新建插件名.Code与插件名.UI 

### 编译输出

生成解决方案后，会输出插件dll至 解决方案/app.publish
