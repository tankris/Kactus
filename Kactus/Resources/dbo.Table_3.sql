CREATE TABLE [dbo].[sites]
(
	[sid] INT NOT NULL , 
    [sname] VARCHAR(50) NULL, 
    [url] VARCHAR(50) NULL, 
    [gid] INT NOT NULL, 
    [uid] INT NOT NULL, 
    [pass] NVARCHAR(50) NULL, 
    [mid] INT NOT NULL, 
    PRIMARY KEY ([mid],[sid],[uid],[gid]), 
    CONSTRAINT [FK_sites_ToTable] FOREIGN KEY ([gid]) REFERENCES [Groups]([gid]),  
    CONSTRAINT [FK_sites_ToTable_2] FOREIGN KEY ([mid]) REFERENCES [Master]([mid]), 
    CONSTRAINT [FK_sites_ToTable_1] FOREIGN KEY ([uid]) REFERENCES [users]([uid]) 
)
