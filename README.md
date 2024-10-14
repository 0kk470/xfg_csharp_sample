# xfg_csharp_sample
息风谷C#Mod示例

* ```DLL```文件夹为引用的息风谷本体DLL, 这些DLL文件仅提供类引用支持，在生成时不会一同复制到生成目录。
* ```xfg_csharp_mod``` 文件夹为Mod工程目录，你可以通过Mod编辑器直接加载此文件夹进行调试，或者将此文件夹拷贝到游戏的Mod目录下进行加载测试。
* ```SamplePlugin.cs``` 为 Plugin的代码示例。
* ```SamplePatcher.cs``` 为Hamonry补丁的代码示例。
* 项目会默认将DLL生成到```xfg_csharp_mod/Csharp```目录下
* .gitignore文件忽略了生成的Debug目录，因此调试```xfg_csharp_mod```前你需要执行一次【生成解决方案】。
