# Unity 3D魔方CFOP教学游戏
![输入图片说明](%E9%AD%94%E6%96%B9%E7%95%8C%E9%9D%A2%E5%9B%BE.png)
#### 介绍
基于Unity开发的魔方教学游戏

#### 使用教程

魔方观察：

- 按键盘上的左边的alt键加鼠标移动360无死角观察游戏魔方
- 按键盘上的v键可用移动鼠标360无死角观察目标魔方


魔方的转动:

- 魔方的转动分为顺时针和逆时针旋转两种，共有18种类型，36种转动方式
- 默认为顺时针旋转，按着键盘ctrl键，切换为逆时针旋转
- 已经包含了CFOP公式的所有所需转动方式



中心转动符：

- 魔方中心块加了转动提示符，转动提示用于参考作用
- 类似于鱼与鱼缸的关系，鱼是可以随意游动（魔方本身）
- 鱼缸是放在那静止不动的（魔方转动提示符)
- 上面的魔方360无死角观察，相当于从不同角度去看鱼缸里的鱼
- 此外，转动提示符可清晰的表述魔方旋转方向，双击转动提示符可快速将其设为F面


魔方状态保存在及复原：

- 点击保存，会保存一个魔方记忆点
- 点击复原，复原会让当前魔方状态回到上一个魔方记忆点，同时视角也会重置


魔方打乱：
- 随机打乱魔方

魔方还原算法：

- 模拟cfop公式的算法，分为四个阶段还原：
- 白色底部十字架，
- 白色底部两层，
- 白色底部两层和黄色顶层翻色，
- 白色底部两层和黄色顶层翻色和黄色顶层顺序调整


提示刷新：

- 点击后，可根据魔方的当前状态去匹配适当的CFOP公式
- 必需以白色为底才能匹配到，其余情况均不行，匹配的公式范围
- 只有F2L、OLL、PLL三种，因Cross没有公式


底十字还原：

- 当魔方处于混乱状态，点击后自动还原为白色底部Cross
- 采用的是小黄花的方式自动还原



#### 参与贡献

1.  Fork 本仓库
2.  新建 Feat_xxx 分支
3.  提交代码
4.  新建 Pull Request


#### 特技

1.  使用 Readme\_XXX.md 来支持不同的语言，例如 Readme\_en.md, Readme\_zh.md
2.  Gitee 官方博客 [blog.gitee.com](https://blog.gitee.com)
3.  你可以 [https://gitee.com/explore](https://gitee.com/explore) 这个地址来了解 Gitee 上的优秀开源项目
4.  [GVP](https://gitee.com/gvp) 全称是 Gitee 最有价值开源项目，是综合评定出的优秀开源项目
5.  Gitee 官方提供的使用手册 [https://gitee.com/help](https://gitee.com/help)
6.  Gitee 封面人物是一档用来展示 Gitee 会员风采的栏目 [https://gitee.com/gitee-stars/](https://gitee.com/gitee-stars/)
