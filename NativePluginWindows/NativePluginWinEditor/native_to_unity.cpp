#include "native_to_unity_notifiers.h"

//#include "winsqlite/winsqlite3.h"
#include "sqlite3.h"

#ifdef __cplusplus
extern "C"
{
#endif

    EXPORT_API void* VirtualFileSystemOpen(const char* filePath)
    {
        auto flags = SQLITE_OPEN_READWRITE | SQLITE_OPEN_CREATE;
        
        sqlite3* database = nullptr;
        int resultCode = sqlite3_open_v2(filePath, &database, flags, nullptr);

        if (resultCode == SQLITE_ERROR)
        {
            // handle error
        }
        else
        {
            // db created or opened
        }

        return database;
    }

    EXPORT_API void VirtualFileSystemClose(void* ptr)
    {
        auto database = (sqlite3*)ptr;
        int resultCode = sqlite3_close_v2(database);

        if (resultCode == SQLITE_ERROR)
        {
            // handle error
        }
        else
        {
            // db created or opened
        }
    }

#ifdef __cplusplus
}
#endif
