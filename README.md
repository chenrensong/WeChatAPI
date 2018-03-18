# WeChatAPI
WeChat Web API（.Net Core) 可用于微信机器人开发


## 使用代码
```
    client = new Client();
    client.ExceptionCatched += Client_ExceptionCatched; ;
    client.GetLoginQrCodeComplete += Client_GetLoginQrCodeComplete; ;
    client.CheckScanComplete += Client_CheckScanComplete; ;
    client.LoginComplete += Client_LoginComplete; ;
    client.BatchGetContactComplete += Client_BatchGetContactComplete; ;
    client.GetContactComplete += Client_GetContactComplete; ;
    client.MPSubscribeMsgListComplete += Client_MPSubscribeMsgListComplete; ;
    client.LogoutComplete += Client_LogoutComplete; ;
    client.ReceiveMsg += Client_ReceiveMsg; ;
    client.DelContactListComplete += Client_DelContactListComplete; ;
    client.ModContactListComplete += Client_ModContactListComplete;
    client.Start();
```
