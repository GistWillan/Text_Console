# TextEncryptDecrypt

这是一个由 Visual Studio 编写并上传至 GitHub 的文字加密解密程序。

## 功能

该程序提供以下功能：

1. **加密：** 用户可以选择 Base64 或 URL(UTF8) 算法对输入的文字进行加密。
2. **解密：** 用户可以选择 Base64 或 URL(UTF8) 算法对输入的文字进行解密。
3. **历史记录：** 程序会保存用户的加密和解密历史记录，并提供查看历史记录的功能。
4. **退出程序：** 用户可以选择退出程序。

## 使用方法

1. 运行程序后，根据菜单选择相应的操作。
2. 若选择加密或解密，程序将要求用户选择加密算法，输入文字，并输出加密或解密结果。
3. 加密或解密后，用户可以选择继续操作、返回菜单或退出程序。

## 加密算法

### Base64 加密

Base64 加密是将文本转换为字节数组，然后再将字节数组转换为 Base64 字符串的过程。

### URL(UTF8) 加密

URL(UTF8) 加密是将文本进行 URL 编码的过程。

## 解密算法

### Base64 解密

Base64 解密是将 Base64 字符串转换为字节数组，然后再将字节数组转换为文本的过程。

### URL(UTF8) 解密

URL(UTF8) 解密是将 URL 编码的文本转换为原始文本的过程。

## 历史记录

用户的加密和解密历史记录将被保存，并可在程序中查看。

## 注意事项

- 输入选择时，请确保输入的是有效选项，否则程序将提示重新输入。

## 作者

该程序由 [GistWillan] 编写。
