﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using imdb_app.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading;
using System.Threading.Tasks;

namespace imdb_app.Models
{
    public partial class imdbContext
    {
        private IimdbContextProcedures _procedures;

        public virtual IimdbContextProcedures Procedures
        {
            get
            {
                if (_procedures is null) _procedures = new imdbContextProcedures(this);
                return _procedures;
            }
            set
            {
                _procedures = value;
            }
        }

        public IimdbContextProcedures GetProcedures()
        {
            return Procedures;
        }

        protected void OnModelCreatingGeneratedProcedures(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<findNameResult>().HasNoKey().ToView(null);
            modelBuilder.Entity<findTitleResult>().HasNoKey().ToView(null);
        }
    }

    public partial class imdbContextProcedures : IimdbContextProcedures
    {
        private readonly imdbContext _context;

        public imdbContextProcedures(imdbContext context)
        {
            _context = context;
        }

        public virtual async Task<int> addNameAsync(string primaryName, short? birthYear, short? deathYear, string profession, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "primaryName",
                    Size = 150,
                    Value = primaryName ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "birthYear",
                    Value = birthYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.SmallInt,
                },
                new SqlParameter
                {
                    ParameterName = "deathYear",
                    Value = deathYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.SmallInt,
                },
                new SqlParameter
                {
                    ParameterName = "profession",
                    Size = 300,
                    Value = profession ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[addName] @primaryName, @birthYear, @deathYear, @profession", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> addTitleAsync(string titleType, string primaryTitle, string originalTitle, bool? isAdult, short? startYear, short? endYear, int? runtimeMinutes, string genre, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "titleType",
                    Size = 50,
                    Value = titleType ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "primaryTitle",
                    Size = 450,
                    Value = primaryTitle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "originalTitle",
                    Size = 450,
                    Value = originalTitle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "isAdult",
                    Value = isAdult ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Bit,
                },
                new SqlParameter
                {
                    ParameterName = "startYear",
                    Value = startYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.SmallInt,
                },
                new SqlParameter
                {
                    ParameterName = "endYear",
                    Value = endYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.SmallInt,
                },
                new SqlParameter
                {
                    ParameterName = "runtimeMinutes",
                    Value = runtimeMinutes ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "genre",
                    Size = 300,
                    Value = genre ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[addTitle] @titleType, @primaryTitle, @originalTitle, @isAdult, @startYear, @endYear, @runtimeMinutes, @genre", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> deleteNameAsync(string nconst, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "nconst",
                    Size = 10,
                    Value = nconst ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[deleteName] @nconst", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> deleteTitleAsync(string tconst, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "tconst",
                    Size = 10,
                    Value = tconst ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[deleteTitle] @tconst", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<findNameResult>> findNameAsync(string name, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "name",
                    Size = -1,
                    Value = name ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<findNameResult>("EXEC @returnValue = [dbo].[findName] @name", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<List<findTitleResult>> findTitleAsync(string title, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "title",
                    Size = -1,
                    Value = title ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.SqlQueryAsync<findTitleResult>("EXEC @returnValue = [dbo].[findTitle] @title", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }

        public virtual async Task<int> updateTitleAsync(string tconst, string titleType, string primaryTitle, string originalTitle, bool? isAdult, short? startYear, short? endYear, int? runtimeMinutes, string genre, OutputParameter<int> returnValue = null, CancellationToken cancellationToken = default)
        {
            var parameterreturnValue = new SqlParameter
            {
                ParameterName = "returnValue",
                Direction = System.Data.ParameterDirection.Output,
                SqlDbType = System.Data.SqlDbType.Int,
            };

            var sqlParameters = new []
            {
                new SqlParameter
                {
                    ParameterName = "tconst",
                    Size = 10,
                    Value = tconst ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "titleType",
                    Size = 50,
                    Value = titleType ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "primaryTitle",
                    Size = 450,
                    Value = primaryTitle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "originalTitle",
                    Size = 450,
                    Value = originalTitle ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                new SqlParameter
                {
                    ParameterName = "isAdult",
                    Value = isAdult ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Bit,
                },
                new SqlParameter
                {
                    ParameterName = "startYear",
                    Value = startYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.SmallInt,
                },
                new SqlParameter
                {
                    ParameterName = "endYear",
                    Value = endYear ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.SmallInt,
                },
                new SqlParameter
                {
                    ParameterName = "runtimeMinutes",
                    Value = runtimeMinutes ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.Int,
                },
                new SqlParameter
                {
                    ParameterName = "genre",
                    Size = 300,
                    Value = genre ?? Convert.DBNull,
                    SqlDbType = System.Data.SqlDbType.VarChar,
                },
                parameterreturnValue,
            };
            var _ = await _context.Database.ExecuteSqlRawAsync("EXEC @returnValue = [dbo].[updateTitle] @tconst, @titleType, @primaryTitle, @originalTitle, @isAdult, @startYear, @endYear, @runtimeMinutes, @genre", sqlParameters, cancellationToken);

            returnValue?.SetValue(parameterreturnValue.Value);

            return _;
        }
    }
}
