#include <stdlib.h>
#include <stdio.h>
#include "../include/apiClient.h"
#include "../include/list.h"
#include "../external/cJSON.h"
#include "../include/keyValuePair.h"
#include "../include/binary.h"
#include "../model/error_response.h"


// Perform SQL requests
//
list_t*_t*
UtilsAPI_sql(apiClient_t *apiClient, char * body );


