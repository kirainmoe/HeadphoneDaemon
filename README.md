# Headphone Daemon

一个检测到耳机拔出时，自动静音扬声器的小工具，适用于 Windows。

至于为什么要写这玩意，那就要从我在实验课上摸鱼听歌，不小心把耳机插孔扯了下来，然后 Windows 检测到耳机被拔掉还不会自动暂停当前播放的媒体，于是整个实验室的人都和我一起欣赏世界名曲一般男性的故事说起了。

关于代码质量，别问，两小时的 C# 从零开始到速成糊出来的东西能有啥质量啊，又不是不能用（嗯！）

## Requirement

使用这个程序需要 .NET Framework，同时要求你的电脑将扬声器和耳机识别为单独的设备（据我所知，例如 Realtek 声卡的 UAD 驱动会将扬声器和耳机都识别为一个播放设备），如下图所示：

![headphone1.png](https://i.loli.net/2020/10/23/1JlZ7QHNt4KvrTp.png)


## Usage

从 [Release 页面](https://github.com/kirainmoe/HeadphoneDaemon/releases) 下载编译好的版本，然后直接双击 EXE 运行就行了。程序会识别默认的输出设备，如果不对的话可以从系统托盘呼出设置界面自行调整。

![image.png](https://i.loli.net/2020/10/23/jQOvZDMmwoRq2iX.png)

![image.png](https://i.loli.net/2020/10/23/qhzFxClo7yvrwkg.png)

![image.png](https://i.loli.net/2020/10/23/GTptJwQjqyzRhZ9.png)



## License 

MIT