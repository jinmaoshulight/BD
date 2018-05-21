﻿namespace System.Data.SQLite
{
    using System;
    using System.Runtime.InteropServices;
    using System.Security;

    [SuppressUnmanagedCodeSecurity]
    internal static class UnsafeNativeMethods
    {
        private const string SQLITE_DLL = "System.Data.SQLite.DLL";

        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_aggregate_context(IntPtr context, int nBytes);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_aggregate_count(IntPtr context);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_blob(IntPtr stmt, int index, byte[] value, int nSize, IntPtr nTransient);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_double(IntPtr stmt, int index, double value);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_int(IntPtr stmt, int index, int value);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_int64(IntPtr stmt, int index, long value);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_null(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_parameter_count(IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_parameter_index(IntPtr stmt, byte[] strName);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_bind_parameter_name_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_bind_text(IntPtr stmt, int index, byte[] value, int nlen, IntPtr pvReserved);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Unicode)]
        internal static extern int sqlite3_bind_text16(IntPtr stmt, int index, string value, int nlen, IntPtr pvReserved);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_busy_timeout(IntPtr db, int ms);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_changes(IntPtr db);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_close_interop(IntPtr db);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_column_blob(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_column_bytes(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_column_count(IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_database_name_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_database_name16_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_decltype_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_decltype16_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern double sqlite3_column_double(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_column_int(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern long sqlite3_column_int64(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_name_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_name16_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_origin_name_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_origin_name16_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_table_name_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_table_name16_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_text_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_column_text16_interop(IntPtr stmt, int index, out int len);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern TypeAffinity sqlite3_column_type(IntPtr stmt, int index);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_commit_hook(IntPtr db, SQLiteCommitCallback func, IntPtr pvUser);
        [DllImport("System.Data.SQLite.DLL", CharSet=CharSet.Unicode, SetLastError=true)]
        internal static extern int sqlite3_compressfile(string fileName);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_context_collcompare(IntPtr context, byte[] p1, int p1len, byte[] p2, int p2len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_context_collseq(IntPtr context, out int type, out int enc, out int len);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_create_collation(IntPtr db, byte[] strName, int nType, IntPtr pvUser, SQLiteCollation func);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_create_function_interop(IntPtr db, byte[] strName, int nArgs, int nType, IntPtr pvUser, SQLiteCallback func, SQLiteCallback fstep, SQLiteFinalCallback ffinal, int needCollSeq);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_cursor_rowid(IntPtr stmt, int cursor, out long rowid);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_db_handle(IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL", CharSet=CharSet.Unicode, SetLastError=true)]
        internal static extern int sqlite3_decompressfile(string fileName);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_errmsg_interop(IntPtr db, out int len);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_exec(IntPtr db, byte[] strSql, IntPtr pvCallback, IntPtr pvParam, out IntPtr errMsg);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_finalize_interop(IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_index_column_info_interop(IntPtr db, byte[] catalog, byte[] IndexName, byte[] ColumnName, out int sortOrder, out int onError, out IntPtr Collation, out int colllen);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_interrupt(IntPtr db);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_key(IntPtr db, byte[] key, int keylen);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_libversion();
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_next_stmt(IntPtr db, IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_open_interop(byte[] utf8Filename, int flags, out IntPtr db);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_open16_interop(byte[] utf8Filename, int flags, out IntPtr db);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_prepare_interop(IntPtr db, IntPtr pSql, int nBytes, out IntPtr stmt, out IntPtr ptrRemain, out int nRemain);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_rekey(IntPtr db, byte[] key, int keylen);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_reset_interop(IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern void sqlite3_resetall_interop(IntPtr db);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_blob(IntPtr context, byte[] value, int nSize, IntPtr pvReserved);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_double(IntPtr context, double value);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_error(IntPtr context, byte[] strErr, int nLen);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Unicode)]
        internal static extern void sqlite3_result_error16(IntPtr context, string strName, int nLen);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_int(IntPtr context, int value);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_int64(IntPtr context, long value);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_null(IntPtr context);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern void sqlite3_result_text(IntPtr context, byte[] value, int nLen, IntPtr pvReserved);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl, CharSet=CharSet.Unicode)]
        internal static extern void sqlite3_result_text16(IntPtr context, string strName, int nLen, IntPtr pvReserved);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_rollback_hook(IntPtr db, SQLiteRollbackCallback func, IntPtr pvUser);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_step(IntPtr stmt);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_table_column_metadata_interop(IntPtr db, byte[] dbName, byte[] tblName, byte[] colName, out IntPtr ptrDataType, out IntPtr ptrCollSeq, out int notNull, out int primaryKey, out int autoInc, out int dtLen, out int csLen);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern int sqlite3_table_cursor(IntPtr stmt, int db, int tableRootPage);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_update_hook(IntPtr db, SQLiteUpdateCallback func, IntPtr pvUser);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern IntPtr sqlite3_value_blob(IntPtr p);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_value_bytes(IntPtr p);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern double sqlite3_value_double(IntPtr p);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern int sqlite3_value_int(IntPtr p);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern long sqlite3_value_int64(IntPtr p);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_value_text_interop(IntPtr p, out int len);
        [DllImport("System.Data.SQLite.DLL")]
        internal static extern IntPtr sqlite3_value_text16_interop(IntPtr p, out int len);
        [DllImport("System.Data.SQLite.DLL", CallingConvention=CallingConvention.Cdecl)]
        internal static extern TypeAffinity sqlite3_value_type(IntPtr p);
    }
}

