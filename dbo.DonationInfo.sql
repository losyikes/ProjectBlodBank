CREATE TABLE [dbo].[DonationInfo]
(
	[UserId] INT NOT NULL PRIMARY KEY, 
    [Amount] INT NOT NULL, 
    [Duration] TIME NULL, 
    [Bloodbagnumber] INT NULL, 
    [Bloodsugar] DECIMAL NULL, 
    [DonationLocation] VARCHAR(50) NULL
)
