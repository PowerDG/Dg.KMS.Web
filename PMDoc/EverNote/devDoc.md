### 核心概念

#### 印象笔记云 API 的重要概念

##### 概述

​					印象笔记云 API 不同于很多 web 服务 API，但是一旦你理解了一些基本例子，就很容易使用它了。 			

- [The UserStore 和 NoteStore](https://dev.yinxiang.com/doc/articles/core_concepts.php#services)
- [使用 the SDK](https://dev.yinxiang.com/doc/articles/core_concepts.php#patterns)



###### UserStore 和 NoteStore

​				云 API 由两个逻辑服务组成：UserStore 和 NoteStore。UserStore  管理印象笔记用户，并且第三方程序通常不使用它。NoteStore 管理用户的印象笔记帐户内容，所以它是你要访问的服务。本章介绍了一些使用云  API 的基本例子。一旦你理解了这些例子，你就可以利用[参考文档](https://dev.yinxiang.com/doc/reference)来查找所有关于 NoteStore 的 API。 		

​				在你使用云 API 做任何事情之前，你需要认证并得到访问某个印象笔记帐户的权限。认证在[认证章节](https://dev.yinxiang.com/doc/articles/authentication.php)详细解释了。当你成功认证后，你将得到两个你需要用来访问 NoteStore 的信息：用来访问 NoteStore 的 URL 和用来访问用户帐户的认证码。每个用户的 NoteStore 的 URL  可能不相同，所以不要把这个 URL 硬编码进代码，也不要假设它一直是不变的。 		



###### 使用 SDK

​				云 API 包含你用来访问 UserStore 和 NoteStore 的封装函数库。你需要创建一个 NoteStore.Client 对象来调用 NoteStore API 函数。 	

```java
// Retrieved during authentication:  
String authToken = ...  
String noteStoreUrl = ...  
  
String userAgent = myCompanyName + " " + myAppName + "/" + myAppVersion;  
  
THttpClient noteStoreTrans = new THttpClient(noteStoreUrl);  
userStoreTrans.setCustomHeader("User-Agent", userAgent);  
TBinaryProtocol noteStoreProt = new TBinaryProtocol(noteStoreTrans);  
NoteStore.Client noteStore = new NoteStore.Client(noteStoreProt, noteStoreProt);
```





​	

​				除了 User-Agent 字符串外，你不需要更改上面代码的其他地方。SDK 中的样例代码展示了如何使用其他语言来做同样的事。如果要使用印象笔记 API 的某个功能，可以直接调用你刚刚创建的 NoteStore.Client 对象里对应的方法： 		

|      | `List notebooks = noteStore.listNotebooks(authToken);` |
| ---- | ------------------------------------------------------ |
|      |                                                        |

​            [view raw](https://gist.github.com/evernotegists/5313817/raw/example.java)            [example.java](https://gist.github.com/evernotegists/5313817#file-example-java)            hosted with ❤ by [GitHub](https://github.com)          

​				上面的代码调用了 [NoteStore.listNotebooks](https://dev.yinxiang.com/doc/reference/NoteStore.html#Fn_NoteStore_listNotebooks) 函数，它返回一个 [NoteStore.listNotebooks](https://dev.yinxiang.com/doc/reference/NoteStore.html#Fn_NoteStore_listNotebooks) 对象列表。服务所返回的笔记本和其他对象仅仅是一些结构－一些你可以读取和写入的独立信息的容器。所有实际的 API 调用都通过  NoteStore.Client  对象完成。当你要在一个印象笔记帐户里创建一个新对象时，你初始化一个对应的数据模型对象的实例，把你想设置的域填入对应的值，然后调用 API 函数： 		

```java
Notebook notebook = new Notebook();  
notebook.setTitle("My fancy new notebook");        
Notebook theNewNotebook = noteStore.createNotebook(authToken, notebook);` 
```





| 1            2            3            4 | `Notebook notebook = new Notebook();  notebook.setTitle("My fancy new notebook");        Notebook theNewNotebook = noteStore.createNotebook(authToken, notebook);` |
| ---------------------------------------- | ------------------------------------------------------------ |
|                                          |                                                              |

​            [view raw](https://gist.github.com/evernotegists/5313818/raw/example.java)            [example.java](https://gist.github.com/evernotegists/5313818#file-example-java)            hosted with ❤ by [GitHub](https://github.com)          

  当你在服务里创建一个新的对象时，它返回这个对象的一个实例，并且这个实例包含一个服务器为这个对象生成的唯一 ID。你将来使用这个实例的时候，你需要这个 ID。你并不需要（而且也不能够）事先填入这些 ID。

|      |      |
| ---- | ---- |
|      |      |





```java
            `String guid = theNewNotebook.getGuid();       
            Note myNewNote = new Note();  note.setNotebookGuid(guid);  
            // ...`          
```



 



​	       [view raw](https://gist.github.com/evernotegists/5313819/raw/example.java)            [example.java](https://gist.github.com/evernotegists/5313819#file-example-java)            hosted with ❤ by [GitHub](https://github.com)          

  现在你理解了使用云 API 的基本例子，你可以参考其他章节来完成更具体的需求。