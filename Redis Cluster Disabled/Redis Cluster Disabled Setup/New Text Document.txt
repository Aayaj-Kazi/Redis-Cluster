cd Primary
del nodes.conf
del appendonly.aof
del dump.rdb
del server_log.txt
start /min cmd /c redis-server.exe redis.windows.conf
cd ..
cd Replica1
del nodes.conf
del appendonly.aof
del dump.rdb
del server_log.txt
start /min cmd /c redis-server.exe redis.windows.conf
cd ..
cd Replica2
del nodes.conf
del appendonly.aof
del dump.rdb
del server_log.txt
start /min cmd /c redis-server.exe redis.windows.conf