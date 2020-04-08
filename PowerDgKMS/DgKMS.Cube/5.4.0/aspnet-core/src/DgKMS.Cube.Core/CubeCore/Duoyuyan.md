

# 配置52ABP-PRO的多语言
 
 
**请注意：**
- 从52ABP-PRO 2.5.0的版本开始默认采用json配置多语言
- 属性名和字段不能重复否则框架会验证失败，需要你删除重复的键名

## Json的配置方法如下

在Cube.Core类库中，找到路径为 Localization->SourceFiles->Json文件夹下的对应文件

### 中文本地化的内容Chinese localized content

找到Json文件夹下的Cube-zh-Hans.json文件，复制以下代码进入即可。

> 请注意防止键名重复，产生异常

```json
                    //的多语言配置==>中文
"Id": "Id",
                    
                     "EvernoteTagGuid": "Guid",
                    "EvernoteTagGuidInputDesc": "请输入Guid",
                     
                    
                     "EvernoteTagName": "Name",
                    "EvernoteTagNameInputDesc": "请输入Name",
                     
                    
                     "EvernoteTagParentGuid": "ParentGuid",
                    "EvernoteTagParentGuidInputDesc": "请输入ParentGuid",
                     
"UpdateSequenceNum": "UpdateSequenceNum",
"IsActive": "IsActive",
"CreationTime": "CreationTime",
"LastModificationTime": "LastModificationTime",
					                     
                    "EvernoteTag": "",
                    "ManageEvernoteTag": "管理",
                    "QueryEvernoteTag": "查询",
                    "CreateEvernoteTag": "添加",
                    "EditEvernoteTag": "编辑",
                    "DeleteEvernoteTag": "删除",
                    "BatchDeleteEvernoteTag": "批量删除",
                    "ExportEvernoteTag": "导出",
                    "EvernoteTagList": "列表",
                     //的多语言配置==End
                    


```


### 英语本地化的内容English localized content
找到Json文件夹下的Cube.json文件，复制以下代码进入即可。
```json
             //的多语言配置==>英文
"Id": "Id",
                    
                     "EvernoteTagGuid": "EvernoteTagGuid",
                    "EvernoteTagGuidInputDesc": "Please input your EvernoteTagGuid",
                     
                    
                     "EvernoteTagName": "EvernoteTagName",
                    "EvernoteTagNameInputDesc": "Please input your EvernoteTagName",
                     
                    
                     "EvernoteTagParentGuid": "EvernoteTagParentGuid",
                    "EvernoteTagParentGuidInputDesc": "Please input your EvernoteTagParentGuid",
                     
"UpdateSequenceNum": "UpdateSequenceNum",
"IsActive": "IsActive",
"CreationTime": "CreationTime",
"LastModificationTime": "LastModificationTime",
					                     
                    "EvernoteTag": "EvernoteTag",
                    "ManageEvernoteTag": "ManageEvernoteTag",
                    "QueryEvernoteTag": "QueryEvernoteTag",
                    "CreateEvernoteTag": "CreateEvernoteTag",
                    "EditEvernoteTag": "EditEvernoteTag",
                    "DeleteEvernoteTag": "DeleteEvernoteTag",
                    "BatchDeleteEvernoteTag": "BatchDeleteEvernoteTag",
                    "ExportEvernoteTag": "ExportEvernoteTag",
                    "EvernoteTagList": "EvernoteTagList",
                     //的多语言配置==End
                    




```