# NamedPipe using application sample

## WcfServiceLibrary1
This WCF Library apps is common interface using for WCF Named Pipe connection.  
`IService1` is so.  
 And const class is defined service end point Uri.  
 ```
 net.pipe://service
 ```

## NamedPipeApplication
This Console apps is server side imitation application.  
It's used in combination with `ClientApp`.  

## ClientApp
This Console apps is client side imitation application.  
It's used in combination with `NamedPipeApplication`.  

## MainApp
This WPF apps is "GURUNAVI WEB SERVICE" tester Application.  

First, create an account of "GURUNAVI WEB SERVICE" here and get APIKey [here](https://ssl.gnavi.co.jp/api/regist/?p=input).  

Please setting add to `MainApp/App.config` file this:
```
    <add key="gnavikeyid" value="{your gurunavi keyid}"/>
```

## Renderer
This WPF apps is outside `MainApp` process, but include renderer function. (maybe)  
It's incomplete project.  
This aims for a multi-process architecture like "chrome".  
Using IPC call other process with named pipe, send binaly object, recive object, rendering...??  
Ummm...I don't know...Difficult!  
