#include "native_to_unity_notifiers.h"

//#include "winsqlite/winsqlite3.h"
#include "sqlite3.h"

#ifdef __cplusplus
extern "C"
{
#endif

	EXPORT_API void VirtualFileSystemRead(const char* database)
    {
        sqlite3* db = nullptr;
        int resultCode = sqlite3_open_v2(database, &db, SQLITE_OPEN_READONLY, nullptr);

        if (resultCode == SQLITE_ERROR)
        {
            // handle error
        }
        else if (resultCode == SQLITE_CANTOPEN)
        {
        }
        else
        {
            // db created or opened
        }
    }

#ifdef __cplusplus
}
#endif
