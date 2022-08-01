# TAPython_Taichi_StableFluid_UE5
在UE5中通过TAPython和Taichi-lang修改体积云覆盖范围的工程。本工程已包含预编译的TAPython插件v1.0.7

![StableFluid In UE5](https://www.tacolor.xyz/images/G011_StableFluid_UE5.gif)


本示例仅供演示TAPython与Taichi-lang在UE5中的通讯之用，非游戏实际实现步骤。


## 先决条件
- Unreal Engine 版本5.0.3 
- 在ProjectSetting/ Plugins-Python/Additional Paths中将当前UE工程中的TA/TAPython/Python 目录加入其中
- unreal的python中安装[taichi-lang](https://www.taichi-lang.org)，确保在unreal的 python console中可以正确导入

  

### UE5中使用其他三方库的推荐做法：
1. 本地安装Python 3.9.7（UE5 使用的Python版本为3.9.7）
2. 创建UE5使用的Python虚拟环境
3. 在虚拟环境中，安装taichi等三方package
4. 在UE5中，将虚拟环境所在目录下的/Lib/site-packages 目录添加到 ProjectSetting/ Plugins-Python/Additional Paths中。重启编辑器


## 演示步骤
- 打开工程，关卡地图为 /Content/StableFluid_Cloud.umap
- 点击 工具栏绿色变色龙图标（Python Chameleon Tools）/ Taichi/Taichi Stable Fluid
- 在黑色窗口点击鼠标绘制
- Have fun

代码路径：
- TAPythonTaichiClouds\TA\TAPython\Python\TaichiStableFluid.py



## 参考

[TAPython文档](https://www.tacolor.xyz/pages/TAPython.html)

[TAPython插件发布页面](https://github.com/cgerchenhp/UE_TAPython_Plugin_Release)

[TAPython中关于修改SImage、RT的更多示例](https://www.tacolor.xyz/Modify_SImage_Content_And_Set_Pixels_to_RenderTarget_in_Unreal_Engine.html)

[TAPython与Taichi联动的最小示例](https://github.com/cgerchenhp/UE_TAPython_Plugin_Release)

[太极图像](https://taichi.graphics/)

[stable_fluid.py from Taichi-dev](
https://github.com/taichi-dev/taichi/blob/master/python/taichi/examples/simulation/stable_fluid.py)


--- 


# TAPython_Taichi_StableFluid_UE5

This is a UE5 demo project for demonstrating how to modify volumetric clouds with only python though TAPython plugin and taichi-lang. This project has already contain the lastest TAPython v1.0.7.



## Prerequisites
- Unreal Engine version 5.0.3 
- Launch project, open Project settings - Plugin Python - additional path, add TAPythonTaichiClouds/TA/TAPython/Python to additional path. then restart the editor.
- install [taichi-lang](https://www.taichi-lang.org) in Unreal Engine, and make sure 'import taichi as ti' works fine in UE's python console

  

### My recommendation for using 3rd python package in UE：
1. Install Python 3.9.7 which is same version of UE5's python
2. Create a virtual environment for UE5 
3. Install the 3rd package in the virtual environment
4. Add the /lib/site-packages directory which under the virtual environment to ProjectSetting/ plugins-python /Additional Paths in Unreal Editor. Relaunch the editor.


## step
- Open the project and the level: /Content/StableFluid_Cloud.umap
- Click the Chameleon icon on the toolbar, Menuitem / Taichi/Taichi Stable Fluid
- Click and drag on the 'black window'
- Have fun

Core python script：
- TAPythonTaichiClouds\TA\TAPython\Python\TaichiStableFluid.py



## reference

[TAPython Documentation](https://www.tacolor.xyz/pages/TAPython.html)

[TAPython Release Page @github](https://github.com/cgerchenhp/UE_TAPython_Plugin_Release)

[More introduce about modify SImage and RenderTarget with Python ](https://www.tacolor.xyz/Modify_SImage_Content_And_Set_Pixels_to_RenderTarget_in_Unreal_Engine.html)

[The minimal example about TAPython and Taichi](https://github.com/cgerchenhp/UE_TAPython_Plugin_Release)

[Taichi Graphics](https://taichi.graphics/)

[stable_fluid.py from Taichi-dev](
https://github.com/taichi-dev/taichi/blob/master/python/taichi/examples/simulation/stable_fluid.py)
