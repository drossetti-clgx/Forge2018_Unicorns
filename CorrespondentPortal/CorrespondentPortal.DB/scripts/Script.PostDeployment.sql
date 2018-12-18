/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
TRUNCATE TABLE [Configurations]

IF '$(Environment)' = 'LOCAL'
BEGIN
	INSERT INTO [CONFIGURATIONS] VALUES ('KeyStoreLocation', 'YourAppsKeyStore');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectKey', '9SWR87LX0BMVHAJW2HEVBWLM7UYUCN570Y8N7AI5');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectSecret', '5RB7OX616X73KV2JR1Z3NPDFP1NVNLTQK936HMD0');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectUrl', 'https://dev.fncconnect.com/');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncFileVaultUrl', 'https://devbravo.fncinc.com/FileVault/');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminLimitedAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminAllAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('SmtpServer','mail.fncinc.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationTo',''); 
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationFrom','no-reply@corelogic.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationCheckInterval','0/5 * * * *');
	INSERT INTO [CONFIGURATIONS] VALUES ('UseHealthCheckNotification','false');
	INSERT INTO [CONFIGURATIONS] VALUES ('SiteURL','YourSiteUrl');
	INSERT INTO [CONFIGURATIONS] VALUES ('InfrastructureLogLevels','Critical|Error');

	--**Example of adding a client
	--IF EXISTS(SELECT 1 FROM dbo.Clients WHERE Id = 68)
	--	UPDATE Clients SET Name = 'CorrespondentPortal', EventCallbackUrl = 'https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/200', CreatedDate = GETDATE() WHERE Id = 68  
	--ELSE
	--	INSERT INTO dbo.Clients (Id, [Name], EventCallbackUrl, CreatedDate) VALUES (68, 'CorrespondentPortal', 'https://devbravo.fncinc.com/statuscodeendpoint/api/statuscode/200', GETDATE())
END
IF '$(Environment)' = 'DEV'
BEGIN
	INSERT INTO [CONFIGURATIONS] VALUES ('KeyStoreLocation', 'YourAppsKeyStore');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectKey', '9SWR87LX0BMVHAJW2HEVBWLM7UYUCN570Y8N7AI5');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectSecret', '5RB7OX616X73KV2JR1Z3NPDFP1NVNLTQK936HMD0');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectUrl', 'https://dev.fncconnect.com/');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncFileVaultUrl', 'https://devbravo.fncinc.com/FileVault/');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminLimitedAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminAllAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('SmtpServer','mail.fncinc.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationTo',''); 
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationFrom','no-reply@corelogic.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationCheckInterval','0/5 * * * *');
	INSERT INTO [CONFIGURATIONS] VALUES ('UseHealthCheckNotification','false');
	INSERT INTO [CONFIGURATIONS] VALUES ('SiteURL','YourSiteUrl');
	INSERT INTO [CONFIGURATIONS] VALUES ('InfrastructureLogLevels','');

--**Add Clients Here**
END
IF '$(Environment)' = 'QA'
BEGIN
	INSERT INTO [CONFIGURATIONS] VALUES ('KeyStoreLocation', 'YourAppsKeyStore');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectKey', 'YourAppsKey');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectSecret', 'YourAppsSecret');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectUrl', 'https://qa.fncconnect.com/');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncFileVaultUrl', 'https://qabravo.fncinc.com/FileVault/');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminLimitedAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminAllAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('SmtpServer','mail.fncinc.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationTo',''); 
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationFrom','no-reply@corelogic.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationCheckInterval','0/5 * * * *');
	INSERT INTO [CONFIGURATIONS] VALUES ('UseHealthCheckNotification','false');
	INSERT INTO [CONFIGURATIONS] VALUES ('SiteURL','YourSiteUrl');
	INSERT INTO [CONFIGURATIONS] VALUES ('InfrastructureLogLevels','');
	
--**Add Clients Here**
END
IF '$(Environment)' = 'UAT'
BEGIN
	INSERT INTO [CONFIGURATIONS] VALUES ('KeyStoreLocation', 'YourAppsKeyStore');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectKey', 'YourAppsKey');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectSecret', 'YourAppsSecret');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectUrl', 'https://uat.fncconnect.com/');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncFileVaultUrl', 'https://uatbravo.fncinc.com/FileVault/');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminLimitedAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminAllAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('SmtpServer','shortestyard.fncinc.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationTo',''); 
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationFrom','no-reply@corelogic.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationCheckInterval','0/5 * * * *');
	INSERT INTO [CONFIGURATIONS] VALUES ('UseHealthCheckNotification','false');
	INSERT INTO [CONFIGURATIONS] VALUES ('SiteURL','YourSiteUrl');
	INSERT INTO [CONFIGURATIONS] VALUES ('InfrastructureLogLevels','');

--**Add Clients Here**
END
IF '$(Environment)' = 'PROD'
BEGIN
	INSERT INTO [CONFIGURATIONS] VALUES ('KeyStoreLocation', 'YourAppsKeyStore');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectKey', 'YourAppsKey');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectSecret', 'YourAppsSecret');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncConnectUrl', 'https://www.fncconnect.com/');
	INSERT INTO [CONFIGURATIONS] VALUES ('FncFileVaultUrl', 'https://entry.gofnc.com/FileVault/');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminLimitedAccessGroups', 'allfnc');
	INSERT INTO [CONFIGURATIONS] VALUES ('AdminAllAccessGroups', '');
	INSERT INTO [CONFIGURATIONS] VALUES ('SmtpServer','longestyard.fncinc.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationTo',''); 
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationFrom','no-reply@corelogic.com');
	INSERT INTO [CONFIGURATIONS] VALUES ('HealthCheckNotificationCheckInterval','0/5 * * * *');
	INSERT INTO [CONFIGURATIONS] VALUES ('UseHealthCheckNotification','false');
	INSERT INTO [CONFIGURATIONS] VALUES ('SiteURL','YourSiteUrl');
	INSERT INTO [CONFIGURATIONS] VALUES ('InfrastructureLogLevels','');
	
--**Add Clients Here**
END