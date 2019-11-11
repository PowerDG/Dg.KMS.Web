# Dg.KMS.Web
夜瓜居士-知识管理体系



 凡事有交代、件件有着落、事事有回音 



---

https://gitee.com/PowerDG/Dg.KMS.Web

git@gitee.com:PowerDG/Dg.KMS.Web.git

 git remote set-url gitee git@gitee.com:https://gitee.com/PowerDG/Dg.KMS.Web.git

DgBook.architect-awesome

 git remote add gitee git@gitee.com/PowerDG/Dg.KMS.Web.git

1、首先通过 **git remote -v** 查看您要同步的仓库的远程库列表，如果在列表中没有您码云的远程库地址，您需要新增一个地址

> git remote add 远程库名 远程库地址
> eg: git remote add gitee git@github.com:xxx/xxx.git

>  如果在 add 的时候出现error: Could not remove config section ‘remote.xxx’.一类的错误，通过把仓库下.git/config 文件里面的 [remote “xxx”] 删掉或者是用别的远程库名即可。 

2、从GitHub上拉取最新代码到本地

> git pull 远程库名 分支名
> eg：git pull origin master

3、推送本地最新代码到码云上

> git push 远程库名 分支名
> eg：git push gitee master



# [Git Push 免输  用户名和密码](https://www.cnblogs.com/ysk123/p/9951443.html)





 `git config --global credential.helper store` 



[remote "gitee"]
	url = https://gitee.com/PowerDG/Dg.KMS.Web.git
	fetch = +refs/heads/*:refs/remotes/gitee/*
	url = https://github.com/PowerDG/Dg.KMS.Web.git