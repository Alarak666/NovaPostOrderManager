﻿using ApplicationManager.Helpers;
using MyLib;
using System.Data;

namespace ApplicationManager.Services.DataBaseService;

public class InternetDocumentDataBaseService
{
    private readonly SQL remoteSql;
    private readonly LogFile? log = null;

    public InternetDocumentDataBaseService()
    {
        (remoteSql, log) = DBHelper.Init();
    }

    public async Task<DataTable> GetApteka()
    {
        var query = @$"
                SELECT 
                    TOP 1 p.code, 
                    rtrim(p.descr) name, 
                    SP287 prefix 
                FROM [base1c].._1sconst c WITH (NOLOCK) 
                    LEFT JOIN [base1c]..sc128 s WITH (NOLOCK) ON s.id = value 
                    LEFT JOIN [base1c]..sc143 p WITH (NOLOCK) ON P.id = SP126 
                    LEFT JOIN [base1c]..sc71 b WITH (NOLOCK) ON b.id = p.SP141
                WHERE c.id = 550";

        return remoteSql.SelectQuery(query, log, "InternetSaleApteka");
    }
}