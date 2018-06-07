USE [aspnet-WK2018]
GO

/****** Object: Table [dbo].[Wedstrijden] Script Date: 7-6-2018 19:41:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Wedstrijden] (
    [ID]          INT           NOT NULL,
    [Datum]       DATETIME2 (7) NOT NULL,
    [ScoreThuis]  INT           NULL,
    [ScoreUit]    INT           NULL,
    [KnockoutID]  INT           NULL,
    [TeamThuisID] INT           NULL,
    [TeamUitID]   INT           NULL
);


GO
CREATE NONCLUSTERED INDEX [IX_Wedstrijden_KnockoutID]
    ON [dbo].[Wedstrijden]([KnockoutID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Wedstrijden_TeamThuisID]
    ON [dbo].[Wedstrijden]([TeamThuisID] ASC);


GO
CREATE NONCLUSTERED INDEX [IX_Wedstrijden_TeamUitID]
    ON [dbo].[Wedstrijden]([TeamUitID] ASC);


GO
ALTER TABLE [dbo].[Wedstrijden]
    ADD CONSTRAINT [PK_Wedstrijden] PRIMARY KEY CLUSTERED ([ID] ASC);


GO
ALTER TABLE [dbo].[Wedstrijden]
    ADD CONSTRAINT [FK_Wedstrijden_KnockoutStages_KnockoutID] FOREIGN KEY ([KnockoutID]) REFERENCES [dbo].[KnockoutStages] ([ID]);


GO
ALTER TABLE [dbo].[Wedstrijden]
    ADD CONSTRAINT [FK_Wedstrijden_Teams_TeamThuisID] FOREIGN KEY ([TeamThuisID]) REFERENCES [dbo].[Teams] ([ID]);


GO
ALTER TABLE [dbo].[Wedstrijden]
    ADD CONSTRAINT [FK_Wedstrijden_Teams_TeamUitID] FOREIGN KEY ([TeamUitID]) REFERENCES [dbo].[Teams] ([ID]);




INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (1, N'2018-06-14 17:00:00', 0, 2, NULL, 1, 2)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (2, N'2018-06-15 14:00:00', 4, 4, NULL, 3, 4)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (3, N'2018-06-19 20:00:00', 4, 4, NULL, 1, 3)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (4, N'2018-06-20 17:00:00', 3, 0, NULL, 4, 3)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (5, N'2018-06-25 16:00:00', 1, 0, NULL, 4, 1)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (6, N'2018-06-25 16:00:00', 4, 3, NULL, 2, 3)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (7, N'2018-06-30 16:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (8, N'2018-06-30 20:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (9, N'2018-07-01 16:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (10, N'2018-07-01 20:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (11, N'2018-07-02 16:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (12, N'2018-07-02 20:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (13, N'2018-07-03 16:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (14, N'2018-07-03 20:00:00', NULL, NULL, 1, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (15, N'2018-07-06 16:00:00', NULL, NULL, 2, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (16, N'2018-07-06 20:00:00', NULL, NULL, 2, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (17, N'2018-07-07 16:00:00', NULL, NULL, 2, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (18, N'2018-07-07 20:00:00', NULL, NULL, 2, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (19, N'2018-07-10 20:00:00', NULL, NULL, 3, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (20, N'2018-07-11 20:00:00', NULL, NULL, 3, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (21, N'2018-07-14 16:00:00', NULL, NULL, 4, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (22, N'2018-07-15 17:00:00', NULL, NULL, 5, NULL, NULL)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (23, N'2018-06-15 20:00:00', 0, 4, NULL, 5, 6)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (24, N'2018-06-20 16:00:00', 4, 2, NULL, 5, 7)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (25, N'2018-06-15 17:00:00', 2, 0, NULL, 7, 8)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (26, N'2018-06-20 20:00:00', 1, 1, NULL, 8, 6)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (27, N'2018-06-25 20:00:00', 1, 1, NULL, 6, 7)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (28, N'2018-06-25 20:00:00', 1, 2, NULL, 8, 5)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (29, N'2018-06-16 12:00:00', 4, 2, NULL, 9, 10)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (30, N'2018-06-16 18:00:00', 0, 4, NULL, 11, 12)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (31, N'2018-06-21 14:00:00', 4, 4, NULL, 12, 10)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (32, N'2018-06-21 17:00:00', 0, 2, NULL, 9, 11)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (33, N'2018-06-26 16:00:00', 4, 1, NULL, 12, 9)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (34, N'2018-06-26 16:00:00', 1, 4, NULL, 10, 11)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (35, N'2018-06-16 15:00:00', 3, 3, NULL, 13, 14)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (36, N'2018-06-16 21:00:00', 3, 3, NULL, 15, 16)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (37, N'2018-06-21 20:00:00', 4, 4, NULL, 13, 15)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (38, N'2018-06-22 17:00:00', 0, 0, NULL, 16, 14)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (39, N'2018-06-26 20:00:00', 2, 4, NULL, 14, 15)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (40, N'2018-06-26 20:00:00', 2, 2, NULL, 16, 13)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (41, N'2018-06-17 14:00:00', 1, 1, NULL, 19, 20)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (42, N'2018-06-17 20:00:00', 0, 3, NULL, 17, 18)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (43, N'2018-06-22 14:00:00', 4, 3, NULL, 17, 19)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (44, N'2018-06-22 20:00:00', 2, 4, NULL, 20, 18)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (45, N'2018-06-27 20:00:00', 0, 1, NULL, 20, 17)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (46, N'2018-06-27 20:00:00', 0, 1, NULL, 18, 19)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (47, N'2018-06-17 17:00:00', 4, 4, NULL, 21, 22)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (48, N'2018-06-18 14:00:00', 1, 2, NULL, 23, 24)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (49, N'2018-06-23 20:00:00', 0, 1, NULL, 21, 23)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (50, N'2018-06-23 17:00:00', 3, 4, NULL, 24, 22)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (51, N'2018-06-27 16:00:00', 2, 4, NULL, 22, 23)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (52, N'2018-06-27 16:00:00', 3, 3, NULL, 24, 21)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (53, N'2018-06-18 17:00:00', 1, 3, NULL, 25, 26)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (54, N'2018-06-18 20:00:00', 1, 2, NULL, 27, 28)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (55, N'2018-06-23 14:00:00', 0, 1, NULL, 25, 27)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (56, N'2018-06-24 14:00:00', 0, 0, NULL, 28, 26)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (57, N'2018-06-28 20:00:00', 0, 2, NULL, 28, 25)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (58, N'2018-06-28 20:00:00', 3, 2, NULL, 26, 27)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (59, N'2018-06-19 14:00:00', 4, 2, NULL, 31, 32)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (60, N'2018-06-19 17:00:00', 2, 1, NULL, 29, 30)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (61, N'2018-06-24 17:00:00', 3, 2, NULL, 32, 30)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (62, N'2018-06-24 20:00:00', 4, 1, NULL, 29, 31)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (63, N'2018-06-28 16:00:00', 3, 2, NULL, 30, 31)
INSERT INTO [dbo].[Wedstrijden] ([ID], [Datum], [ScoreThuis], [ScoreUit], [KnockoutID], [TeamThuisID], [TeamUitID]) VALUES (64, N'2018-06-28 16:00:00', 3, 0, NULL, 32, 29)
