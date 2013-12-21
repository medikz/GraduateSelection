教师账号： 05514:kxy
管理员:FFFFF:123456
学生：1219010424:zhangsan


修改说明：
1. namespace WebApplication1
{}
全部都删了，即所有类都不在子空间下。
2. MessageBox.Show(）在asp.net下不能用。而是都转换成了
 Response.Write("<script>window.alert('请先登录');</script>");
如果有逻辑判断的if(==MessageBox.Show(）)，暂时我注销了，让其直接运行。你们可以通过判断再写下。

3. 做好的程序用vs 2008.net->build->Publish website，编译后会在类似文档目录下生成，你也可以自己选目录C:\Users\Kong\Documents\Visual Studio 2008\Projects\WebSite3\PrecompiledWeb\ 把生成的 文件夹内的文件上传到 web/bbs/usst,而bin目录要传到web/bbs下面。bin目录要在bbs目录这是网站的根目录。每次编译后 所有文件都要传一次。因为bin和相关内容会改变。