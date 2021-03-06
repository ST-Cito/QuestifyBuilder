SET NUMERIC_ROUNDABORT OFF
GO
SET XACT_ABORT, ANSI_PADDING, ANSI_WARNINGS, CONCAT_NULL_YIELDS_NULL, ARITHABORT, QUOTED_IDENTIFIER, ANSI_NULLS, NOCOUNT ON
GO
-- Pointer used for text / image updates. This might not be needed, but is declared here just in case
DECLARE @pv binary(16)

BEGIN TRANSACTION

-- Drop constraints from [dbo].[UserBankRole]
ALTER TABLE [dbo].[UserBankRole] DROP CONSTRAINT [FK_UserBankRole_Bank]
ALTER TABLE [dbo].[UserBankRole] DROP CONSTRAINT [FK_UserBankRole_Role]
ALTER TABLE [dbo].[UserBankRole] DROP CONSTRAINT [FK_UserBankRole_User]

-- Drop constraints from [dbo].[UserApplicationRole]
ALTER TABLE [dbo].[UserApplicationRole] DROP CONSTRAINT [FK_UserApplicationRole_Role]
ALTER TABLE [dbo].[UserApplicationRole] DROP CONSTRAINT [FK_UserApplicationRole_User]

-- Drop constraints from [dbo].[RolePermission]
ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_RolePermission_Permission]
ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_RolePermission_PermissionTarget]
ALTER TABLE [dbo].[RolePermission] DROP CONSTRAINT [FK_RolePermission_Role]

-- Drop constraints from [dbo].[Role]
ALTER TABLE [dbo].[Role] DROP CONSTRAINT [FK_Role_UserCreatedBy]
ALTER TABLE [dbo].[Role] DROP CONSTRAINT [FK_Role_UserModifiedBy]

-- Drop constraints from [dbo].[Bank]
ALTER TABLE [dbo].[Bank] DROP CONSTRAINT [FK_Bank_Bank]
ALTER TABLE [dbo].[Bank] DROP CONSTRAINT [FK_Bank_CreatedByUser]
ALTER TABLE [dbo].[Bank] DROP CONSTRAINT [FK_Bank_ModifiedByUser]

-- Drop constraint FK_Resource_Bank from [dbo].[Resource]
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_Bank]

-- Drop constraints from [dbo].[User]
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_Client]
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_CreatedBy]
ALTER TABLE [dbo].[User] DROP CONSTRAINT [FK_User_ModifiedBy]

-- Drop constraint FK_Resource_User from [dbo].[Resource]
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_User]

-- Drop constraint FK_Resource_User1 from [dbo].[Resource]
ALTER TABLE [dbo].[Resource] DROP CONSTRAINT [FK_Resource_User1]

-- Add 1 row to [dbo].[Client]
SET IDENTITY_INSERT [dbo].[Client] ON
INSERT INTO [dbo].[Client] ([id], [name], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 'CITO', '20071127 10:33:08.143', 1, '20071127 10:33:08.143', 1)
SET IDENTITY_INSERT [dbo].[Client] OFF

-- Add 18 rows to [dbo].[Permission]
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 'Execute', 'Permits to execute the named task', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (2, 'AddNew', 'Permits to view entity attributes', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (3, 'Refer', 'Permits to list entity instances', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (4, 'List', 'Permits all PL level access', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (5, 'View', 'Permits to view the attributes', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (6, 'Edit', 'Permits to view and change the..', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (7, 'Delete', 'Permits to delete...', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (8, 'Publish', 'Permits to publish', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (9, 'Export', 'Permits to export...', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (10, 'Import', 'Permits to import...', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (11, 'ViewSource', 'Permits to view the source representation ....', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (12, 'ViewProperties', 'Permits viewing the properties of the ', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (13, 'EditProperties', 'Permits changing properties ...', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (14, 'ImportRawData', 'Permits to import raw entity data ...', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (15, 'ExportRawData', 'Permits to export raw entity data ...', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (16, 'AddDependency', 'Permits to add dependencies ....', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (17, 'DeleteDependency', 'Permits to delete dependencies', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Permission] ([id], [name], [description], [whenOwnerCondition], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (30, 'FullAccess', 'Permits all permittable actions', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)

-- Add 15 rows to [dbo].[PermissionTarget]
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 'NamedTask', 'SwitchItemEditorToDesignMode', 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (2, 'BankEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (3, 'TestEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (4, 'TestTemplateEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (5, 'ItemEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (6, 'ItemLayoutTemplateEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (7, 'MediaEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (8, 'ControlTemplateEntity', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (11, 'UserEntity', NULL, 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (12, 'UserApplicationRoleEntity', NULL, 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (13, 'UserBankRoleEntity', NULL, 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (14, 'RoleEntity', NULL, 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (15, 'RolePermissionEntity', NULL, 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[PermissionTarget] ([id], [name], [targettedNamedTask], [isApplicationTarget], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (20, 'AllTargets', NULL, 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)

-- Add 2 rows to [dbo].[User]
SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([id], [userName], [password], [fullName], [Active], [creationDate], [createdBy], [modifiedDate], [modifiedBy], [authenticationType]) VALUES (1, 'testDefault', 'testen', 'Default Tester', 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1, 'Default')
INSERT INTO [dbo].[User] ([id], [userName], [password], [fullName], [Active], [creationDate], [createdBy], [modifiedDate], [modifiedBy], [authenticationType]) VALUES (2, 'test1', 'testen', 'ActiveDirectory Tester', 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1, 'ActiveDirectory')
SET IDENTITY_INSERT [dbo].[User] OFF

-- Add 2 rows to [dbo].[Bank]
SET IDENTITY_INSERT [dbo].[Bank] ON
INSERT INTO [dbo].[Bank] ([id], [parentBankId], [name], [type], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, NULL, 'Bank1', NULL, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Bank] ([id], [parentBankId], [name], [type], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (2, 1, 'Bank11', NULL, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
SET IDENTITY_INSERT [dbo].[Bank] OFF

-- Add 4 rows to [dbo].[Role]
SET IDENTITY_INSERT [dbo].[Role] ON
INSERT INTO [dbo].[Role] ([id], [name], [description], [isApplicationRole], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 'Role1', 'Role1', 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Role] ([id], [name], [description], [isApplicationRole], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (2, 'Role2', 'Role2', 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Role] ([id], [name], [description], [isApplicationRole], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (3, 'Role3', 'Role3', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[Role] ([id], [name], [description], [isApplicationRole], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (4, 'Role4', 'Role4', 0, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
SET IDENTITY_INSERT [dbo].[Role] OFF

-- Add 2 row to [dbo].[RolePermission]
INSERT INTO [dbo].[RolePermission] ([roleId], [permissionTargetId], [permissionId], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 20, 30, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[RolePermission] ([roleId], [permissionTargetId], [permissionId], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (3, 20, 30, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)

-- Add 2 rows to [dbo].[UserApplicationRole]
INSERT INTO [dbo].[UserApplicationRole] ([userId], [applicationRoleId], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 1, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)
INSERT INTO [dbo].[UserApplicationRole] ([userId], [applicationRoleId], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 2, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)

-- Add 1 row to [dbo].[UserBankRole]
INSERT INTO [dbo].[UserBankRole] ([userId], [bankId], [bankRoleId], [creationDate], [createdBy], [modifiedDate], [modifiedBy]) VALUES (1, 1, 3, '20071127 10:33:08.000', 1, '20071127 10:33:08.000', 1)

-- Add constraints to [dbo].[UserBankRole]
ALTER TABLE [dbo].[UserBankRole] WITH NOCHECK ADD CONSTRAINT [FK_UserBankRole_Bank] FOREIGN KEY ([bankId]) REFERENCES [dbo].[Bank] ([id]) ON DELETE CASCADE
ALTER TABLE [dbo].[UserBankRole] WITH NOCHECK ADD CONSTRAINT [FK_UserBankRole_Role] FOREIGN KEY ([bankRoleId]) REFERENCES [dbo].[Role] ([id])
ALTER TABLE [dbo].[UserBankRole] WITH NOCHECK ADD CONSTRAINT [FK_UserBankRole_User] FOREIGN KEY ([userId]) REFERENCES [dbo].[User] ([id])

-- Add constraints to [dbo].[UserApplicationRole]
ALTER TABLE [dbo].[UserApplicationRole] WITH NOCHECK ADD CONSTRAINT [FK_UserApplicationRole_Role] FOREIGN KEY ([applicationRoleId]) REFERENCES [dbo].[Role] ([id])
ALTER TABLE [dbo].[UserApplicationRole] WITH NOCHECK ADD CONSTRAINT [FK_UserApplicationRole_User] FOREIGN KEY ([userId]) REFERENCES [dbo].[User] ([id])

-- Add constraints to [dbo].[RolePermission]
ALTER TABLE [dbo].[RolePermission] WITH NOCHECK ADD CONSTRAINT [FK_RolePermission_Permission] FOREIGN KEY ([permissionId]) REFERENCES [dbo].[Permission] ([id])
ALTER TABLE [dbo].[RolePermission] WITH NOCHECK ADD CONSTRAINT [FK_RolePermission_PermissionTarget] FOREIGN KEY ([permissionTargetId]) REFERENCES [dbo].[PermissionTarget] ([id])
ALTER TABLE [dbo].[RolePermission] WITH NOCHECK ADD CONSTRAINT [FK_RolePermission_Role] FOREIGN KEY ([roleId]) REFERENCES [dbo].[Role] ([id])

-- Add constraints to [dbo].[Role]
ALTER TABLE [dbo].[Role] WITH NOCHECK ADD CONSTRAINT [FK_Role_UserCreatedBy] FOREIGN KEY ([createdBy]) REFERENCES [dbo].[User] ([id])
ALTER TABLE [dbo].[Role] WITH NOCHECK ADD CONSTRAINT [FK_Role_UserModifiedBy] FOREIGN KEY ([modifiedBy]) REFERENCES [dbo].[User] ([id])

-- Add constraints to [dbo].[Bank]
ALTER TABLE [dbo].[Bank] WITH NOCHECK ADD CONSTRAINT [FK_Bank_Bank] FOREIGN KEY ([parentBankId]) REFERENCES [dbo].[Bank] ([id])
ALTER TABLE [dbo].[Bank] WITH NOCHECK ADD CONSTRAINT [FK_Bank_CreatedByUser] FOREIGN KEY ([createdBy]) REFERENCES [dbo].[User] ([id])
ALTER TABLE [dbo].[Bank] WITH NOCHECK ADD CONSTRAINT [FK_Bank_ModifiedByUser] FOREIGN KEY ([modifiedBy]) REFERENCES [dbo].[User] ([id])

-- Add constraint FK_Resource_Bank to [dbo].[Resource]
ALTER TABLE [dbo].[Resource] WITH NOCHECK ADD CONSTRAINT [FK_Resource_Bank] FOREIGN KEY ([bankId]) REFERENCES [dbo].[Bank] ([id])

-- Add constraints to [dbo].[User]
ALTER TABLE [dbo].[User] WITH NOCHECK ADD CONSTRAINT [FK_User_CreatedBy] FOREIGN KEY ([createdBy]) REFERENCES [dbo].[User] ([id])
ALTER TABLE [dbo].[User] WITH NOCHECK ADD CONSTRAINT [FK_User_ModifiedBy] FOREIGN KEY ([modifiedBy]) REFERENCES [dbo].[User] ([id])

-- Add constraint FK_Resource_User to [dbo].[Resource]
ALTER TABLE [dbo].[Resource] WITH NOCHECK ADD CONSTRAINT [FK_Resource_User] FOREIGN KEY ([createdBy]) REFERENCES [dbo].[User] ([id])

-- Add constraint FK_Resource_User1 to [dbo].[Resource]
ALTER TABLE [dbo].[Resource] WITH NOCHECK ADD CONSTRAINT [FK_Resource_User1] FOREIGN KEY ([modifiedBy]) REFERENCES [dbo].[User] ([id])

COMMIT TRANSACTION
