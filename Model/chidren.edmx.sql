
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/05/2017 13:24:48
-- Generated from EDMX file: C:\Users\Administrator\Desktop\童玩吧\发布\chidren\Model\chidren.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;

USE [chidren];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_用户喜欢记录]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[喜欢记录Set] DROP CONSTRAINT [FK_用户喜欢记录];
GO
IF OBJECT_ID(N'[dbo].[FK_用户报名记录]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[报名记录Set] DROP CONSTRAINT [FK_用户报名记录];
GO
IF OBJECT_ID(N'[dbo].[FK_用户关注]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[关注Set] DROP CONSTRAINT [FK_用户关注];
GO
IF OBJECT_ID(N'[dbo].[FK_用户活动]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[活动Set] DROP CONSTRAINT [FK_用户活动];
GO
IF OBJECT_ID(N'[dbo].[FK_用户活动评论]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[活动评论Set] DROP CONSTRAINT [FK_用户活动评论];
GO
IF OBJECT_ID(N'[dbo].[FK_活动精选活动]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[精选活动Set] DROP CONSTRAINT [FK_活动精选活动];
GO
IF OBJECT_ID(N'[dbo].[FK_活动喜欢记录]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[喜欢记录Set] DROP CONSTRAINT [FK_活动喜欢记录];
GO
IF OBJECT_ID(N'[dbo].[FK_活动活动评论]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[活动评论Set] DROP CONSTRAINT [FK_活动活动评论];
GO
IF OBJECT_ID(N'[dbo].[FK_活动报名记录]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[报名记录Set] DROP CONSTRAINT [FK_活动报名记录];
GO
IF OBJECT_ID(N'[dbo].[FK_动态动态附件]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[动态附件Set] DROP CONSTRAINT [FK_动态动态附件];
GO
IF OBJECT_ID(N'[dbo].[FK_用户相册]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[相册Set] DROP CONSTRAINT [FK_用户相册];
GO
IF OBJECT_ID(N'[dbo].[FK_用户动态]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[动态Set] DROP CONSTRAINT [FK_用户动态];
GO
IF OBJECT_ID(N'[dbo].[FK_动态动态点赞记录]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[动态点赞记录Set] DROP CONSTRAINT [FK_动态动态点赞记录];
GO
IF OBJECT_ID(N'[dbo].[FK_用户动态点赞记录]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[动态点赞记录Set] DROP CONSTRAINT [FK_用户动态点赞记录];
GO
IF OBJECT_ID(N'[dbo].[FK_用户意见反馈]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[意见反馈Set] DROP CONSTRAINT [FK_用户意见反馈];
GO
IF OBJECT_ID(N'[dbo].[FK_动态动态评论]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[动态评论Set] DROP CONSTRAINT [FK_动态动态评论];
GO
IF OBJECT_ID(N'[dbo].[FK_用户动态评论]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[动态评论Set] DROP CONSTRAINT [FK_用户动态评论];
GO
IF OBJECT_ID(N'[dbo].[FK_主题活动]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[活动Set] DROP CONSTRAINT [FK_主题活动];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[用户Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[用户Set];
GO
IF OBJECT_ID(N'[dbo].[管理员Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[管理员Set];
GO
IF OBJECT_ID(N'[dbo].[广告轮播Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[广告轮播Set];
GO
IF OBJECT_ID(N'[dbo].[喜欢记录Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[喜欢记录Set];
GO
IF OBJECT_ID(N'[dbo].[报名记录Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[报名记录Set];
GO
IF OBJECT_ID(N'[dbo].[精选活动Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[精选活动Set];
GO
IF OBJECT_ID(N'[dbo].[活动Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[活动Set];
GO
IF OBJECT_ID(N'[dbo].[关注Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[关注Set];
GO
IF OBJECT_ID(N'[dbo].[活动评论Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[活动评论Set];
GO
IF OBJECT_ID(N'[dbo].[意见反馈Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[意见反馈Set];
GO
IF OBJECT_ID(N'[dbo].[相册Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[相册Set];
GO
IF OBJECT_ID(N'[dbo].[动态Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[动态Set];
GO
IF OBJECT_ID(N'[dbo].[动态附件Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[动态附件Set];
GO
IF OBJECT_ID(N'[dbo].[动态点赞记录Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[动态点赞记录Set];
GO
IF OBJECT_ID(N'[dbo].[动态评论Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[动态评论Set];
GO
IF OBJECT_ID(N'[dbo].[主题Set]', 'U') IS NOT NULL
    DROP TABLE [dbo].[主题Set];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table '用户Set'
CREATE TABLE [dbo].[用户Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [昵称] nvarchar(50)  NOT NULL,
    [密码] nvarchar(200)  NOT NULL,
    [手机号] nvarchar(11)  NOT NULL,
    [头像] nvarchar(max)  NULL,
    [类别] nvarchar(max)  NULL,
    [生日] datetime  NOT NULL,
    [地址] nvarchar(200)  NULL,
    [delete] bit  NULL,
    [性别] nvarchar(4)  NOT NULL,
    [个性签名] nvarchar(200)  NULL
);
GO

-- Creating table '管理员Set'
CREATE TABLE [dbo].[管理员Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [登录名] nvarchar(max)  NOT NULL,
    [姓名] nvarchar(max)  NOT NULL,
    [管理类型] nvarchar(max)  NOT NULL,
    [管理等级] bigint  NOT NULL
);
GO

-- Creating table '广告轮播Set'
CREATE TABLE [dbo].[广告轮播Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [图片] nvarchar(max)  NOT NULL,
    [活动编号] bigint  NOT NULL,
    [广告链接] nvarchar(max)  NOT NULL,
    [广告标题] nvarchar(max)  NOT NULL,
    [广告信息] nvarchar(max)  NOT NULL,
    [类别] nvarchar(max)  NOT NULL
);
GO

-- Creating table '喜欢记录Set'
CREATE TABLE [dbo].[喜欢记录Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [喜欢时间] datetime  NOT NULL,
    [用户Id] int  NOT NULL,
    [活动Id] int  NOT NULL
);
GO

-- Creating table '报名记录Set'
CREATE TABLE [dbo].[报名记录Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [报名时间] datetime  NOT NULL,
    [是否失效] bit  NOT NULL,
    [用户Id] int  NOT NULL,
    [活动Id] int  NOT NULL,
    [姓名] nvarchar(max)  NULL,
    [联系方式] nvarchar(max)  NULL
);
GO

-- Creating table '精选活动Set'
CREATE TABLE [dbo].[精选活动Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [价格] bigint  NOT NULL,
    [活动Id] int  NOT NULL
);
GO

-- Creating table '活动Set'
CREATE TABLE [dbo].[活动Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [标题] nvarchar(50)  NOT NULL,
    [内容] nvarchar(max)  NOT NULL,
    [主题图片] nvarchar(200)  NOT NULL,
    [活动地址] nvarchar(100)  NOT NULL,
    [开始时间] datetime  NOT NULL,
    [结束时间] datetime  NOT NULL,
    [报名截止时间] datetime  NOT NULL,
    [阅读人数] bigint  NOT NULL,
    [喜欢人数] bigint  NOT NULL,
    [报名人数] bigint  NOT NULL,
    [delete] bit  NULL,
    [用户Id] int  NOT NULL,
    [发起时间] datetime  NULL,
    [主题Id] int  NOT NULL
);
GO

-- Creating table '关注Set'
CREATE TABLE [dbo].[关注Set] (
    [id] int IDENTITY(1,1) NOT NULL,
    [好友编号] int  NOT NULL,
    [用户Id] int  NOT NULL
);
GO

-- Creating table '活动评论Set'
CREATE TABLE [dbo].[活动评论Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [评论时间] datetime  NOT NULL,
    [内容] nvarchar(max)  NOT NULL,
    [delete] bit  NOT NULL,
    [用户Id] int  NOT NULL,
    [活动Id] int  NOT NULL
);
GO

-- Creating table '意见反馈Set'
CREATE TABLE [dbo].[意见反馈Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [内容] nvarchar(max)  NOT NULL,
    [联系方式] nvarchar(20)  NOT NULL,
    [用户Id] int  NOT NULL
);
GO

-- Creating table '相册Set'
CREATE TABLE [dbo].[相册Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [图片地址] nvarchar(max)  NOT NULL,
    [用户Id] int  NOT NULL
);
GO

-- Creating table '动态Set'
CREATE TABLE [dbo].[动态Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [内容] nvarchar(max)  NOT NULL,
    [发布时间] datetime  NOT NULL,
    [点赞数] int  NOT NULL,
    [delete] bit  NULL,
    [用户Id] int  NOT NULL
);
GO

-- Creating table '动态附件Set'
CREATE TABLE [dbo].[动态附件Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [图片地址] nvarchar(max)  NOT NULL,
    [动态Id] int  NOT NULL
);
GO

-- Creating table '动态点赞记录Set'
CREATE TABLE [dbo].[动态点赞记录Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [点赞时间] datetime  NOT NULL,
    [动态Id] int  NOT NULL,
    [用户Id] int  NOT NULL
);
GO

-- Creating table '动态评论Set'
CREATE TABLE [dbo].[动态评论Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [delete] bit  NULL,
    [内容] nvarchar(200)  NOT NULL,
    [评论时间] datetime  NOT NULL,
    [动态Id] int  NOT NULL,
    [用户Id] int  NOT NULL
);
GO

-- Creating table '主题Set'
CREATE TABLE [dbo].[主题Set] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [名称] nvarchar(20)  NOT NULL,
    [图片] nvarchar(250)  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table '用户Set'
ALTER TABLE [dbo].[用户Set]
ADD CONSTRAINT [PK_用户Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '管理员Set'
ALTER TABLE [dbo].[管理员Set]
ADD CONSTRAINT [PK_管理员Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '广告轮播Set'
ALTER TABLE [dbo].[广告轮播Set]
ADD CONSTRAINT [PK_广告轮播Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '喜欢记录Set'
ALTER TABLE [dbo].[喜欢记录Set]
ADD CONSTRAINT [PK_喜欢记录Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '报名记录Set'
ALTER TABLE [dbo].[报名记录Set]
ADD CONSTRAINT [PK_报名记录Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '精选活动Set'
ALTER TABLE [dbo].[精选活动Set]
ADD CONSTRAINT [PK_精选活动Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '活动Set'
ALTER TABLE [dbo].[活动Set]
ADD CONSTRAINT [PK_活动Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [id] in table '关注Set'
ALTER TABLE [dbo].[关注Set]
ADD CONSTRAINT [PK_关注Set]
    PRIMARY KEY CLUSTERED ([id] ASC);
GO

-- Creating primary key on [Id] in table '活动评论Set'
ALTER TABLE [dbo].[活动评论Set]
ADD CONSTRAINT [PK_活动评论Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '意见反馈Set'
ALTER TABLE [dbo].[意见反馈Set]
ADD CONSTRAINT [PK_意见反馈Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '相册Set'
ALTER TABLE [dbo].[相册Set]
ADD CONSTRAINT [PK_相册Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '动态Set'
ALTER TABLE [dbo].[动态Set]
ADD CONSTRAINT [PK_动态Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '动态附件Set'
ALTER TABLE [dbo].[动态附件Set]
ADD CONSTRAINT [PK_动态附件Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '动态点赞记录Set'
ALTER TABLE [dbo].[动态点赞记录Set]
ADD CONSTRAINT [PK_动态点赞记录Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '动态评论Set'
ALTER TABLE [dbo].[动态评论Set]
ADD CONSTRAINT [PK_动态评论Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table '主题Set'
ALTER TABLE [dbo].[主题Set]
ADD CONSTRAINT [PK_主题Set]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [用户Id] in table '喜欢记录Set'
ALTER TABLE [dbo].[喜欢记录Set]
ADD CONSTRAINT [FK_用户喜欢记录]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户喜欢记录'
CREATE INDEX [IX_FK_用户喜欢记录]
ON [dbo].[喜欢记录Set]
    ([用户Id]);
GO

-- Creating foreign key on [用户Id] in table '报名记录Set'
ALTER TABLE [dbo].[报名记录Set]
ADD CONSTRAINT [FK_用户报名记录]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户报名记录'
CREATE INDEX [IX_FK_用户报名记录]
ON [dbo].[报名记录Set]
    ([用户Id]);
GO

-- Creating foreign key on [用户Id] in table '关注Set'
ALTER TABLE [dbo].[关注Set]
ADD CONSTRAINT [FK_用户关注]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户关注'
CREATE INDEX [IX_FK_用户关注]
ON [dbo].[关注Set]
    ([用户Id]);
GO

-- Creating foreign key on [用户Id] in table '活动Set'
ALTER TABLE [dbo].[活动Set]
ADD CONSTRAINT [FK_用户活动]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户活动'
CREATE INDEX [IX_FK_用户活动]
ON [dbo].[活动Set]
    ([用户Id]);
GO

-- Creating foreign key on [用户Id] in table '活动评论Set'
ALTER TABLE [dbo].[活动评论Set]
ADD CONSTRAINT [FK_用户活动评论]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户活动评论'
CREATE INDEX [IX_FK_用户活动评论]
ON [dbo].[活动评论Set]
    ([用户Id]);
GO

-- Creating foreign key on [活动Id] in table '精选活动Set'
ALTER TABLE [dbo].[精选活动Set]
ADD CONSTRAINT [FK_活动精选活动]
    FOREIGN KEY ([活动Id])
    REFERENCES [dbo].[活动Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_活动精选活动'
CREATE INDEX [IX_FK_活动精选活动]
ON [dbo].[精选活动Set]
    ([活动Id]);
GO

-- Creating foreign key on [活动Id] in table '喜欢记录Set'
ALTER TABLE [dbo].[喜欢记录Set]
ADD CONSTRAINT [FK_活动喜欢记录]
    FOREIGN KEY ([活动Id])
    REFERENCES [dbo].[活动Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_活动喜欢记录'
CREATE INDEX [IX_FK_活动喜欢记录]
ON [dbo].[喜欢记录Set]
    ([活动Id]);
GO

-- Creating foreign key on [活动Id] in table '活动评论Set'
ALTER TABLE [dbo].[活动评论Set]
ADD CONSTRAINT [FK_活动活动评论]
    FOREIGN KEY ([活动Id])
    REFERENCES [dbo].[活动Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_活动活动评论'
CREATE INDEX [IX_FK_活动活动评论]
ON [dbo].[活动评论Set]
    ([活动Id]);
GO

-- Creating foreign key on [活动Id] in table '报名记录Set'
ALTER TABLE [dbo].[报名记录Set]
ADD CONSTRAINT [FK_活动报名记录]
    FOREIGN KEY ([活动Id])
    REFERENCES [dbo].[活动Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_活动报名记录'
CREATE INDEX [IX_FK_活动报名记录]
ON [dbo].[报名记录Set]
    ([活动Id]);
GO

-- Creating foreign key on [动态Id] in table '动态附件Set'
ALTER TABLE [dbo].[动态附件Set]
ADD CONSTRAINT [FK_动态动态附件]
    FOREIGN KEY ([动态Id])
    REFERENCES [dbo].[动态Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_动态动态附件'
CREATE INDEX [IX_FK_动态动态附件]
ON [dbo].[动态附件Set]
    ([动态Id]);
GO

-- Creating foreign key on [用户Id] in table '相册Set'
ALTER TABLE [dbo].[相册Set]
ADD CONSTRAINT [FK_用户相册]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户相册'
CREATE INDEX [IX_FK_用户相册]
ON [dbo].[相册Set]
    ([用户Id]);
GO

-- Creating foreign key on [用户Id] in table '动态Set'
ALTER TABLE [dbo].[动态Set]
ADD CONSTRAINT [FK_用户动态]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户动态'
CREATE INDEX [IX_FK_用户动态]
ON [dbo].[动态Set]
    ([用户Id]);
GO

-- Creating foreign key on [动态Id] in table '动态点赞记录Set'
ALTER TABLE [dbo].[动态点赞记录Set]
ADD CONSTRAINT [FK_动态动态点赞记录]
    FOREIGN KEY ([动态Id])
    REFERENCES [dbo].[动态Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_动态动态点赞记录'
CREATE INDEX [IX_FK_动态动态点赞记录]
ON [dbo].[动态点赞记录Set]
    ([动态Id]);
GO

-- Creating foreign key on [用户Id] in table '动态点赞记录Set'
ALTER TABLE [dbo].[动态点赞记录Set]
ADD CONSTRAINT [FK_用户动态点赞记录]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户动态点赞记录'
CREATE INDEX [IX_FK_用户动态点赞记录]
ON [dbo].[动态点赞记录Set]
    ([用户Id]);
GO

-- Creating foreign key on [用户Id] in table '意见反馈Set'
ALTER TABLE [dbo].[意见反馈Set]
ADD CONSTRAINT [FK_用户意见反馈]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户意见反馈'
CREATE INDEX [IX_FK_用户意见反馈]
ON [dbo].[意见反馈Set]
    ([用户Id]);
GO

-- Creating foreign key on [动态Id] in table '动态评论Set'
ALTER TABLE [dbo].[动态评论Set]
ADD CONSTRAINT [FK_动态动态评论]
    FOREIGN KEY ([动态Id])
    REFERENCES [dbo].[动态Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_动态动态评论'
CREATE INDEX [IX_FK_动态动态评论]
ON [dbo].[动态评论Set]
    ([动态Id]);
GO

-- Creating foreign key on [用户Id] in table '动态评论Set'
ALTER TABLE [dbo].[动态评论Set]
ADD CONSTRAINT [FK_用户动态评论]
    FOREIGN KEY ([用户Id])
    REFERENCES [dbo].[用户Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_用户动态评论'
CREATE INDEX [IX_FK_用户动态评论]
ON [dbo].[动态评论Set]
    ([用户Id]);
GO

-- Creating foreign key on [主题Id] in table '活动Set'
ALTER TABLE [dbo].[活动Set]
ADD CONSTRAINT [FK_主题活动]
    FOREIGN KEY ([主题Id])
    REFERENCES [dbo].[主题Set]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_主题活动'
CREATE INDEX [IX_FK_主题活动]
ON [dbo].[活动Set]
    ([主题Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------