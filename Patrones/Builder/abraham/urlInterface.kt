
interface urlInterface {
    fun setProtocol(protocol: String)
    fun setHostName(hostname: String)
    fun setPort(port: String)
    fun addPath(path: String)
    fun addQueryParam(key: String, value: String)
    fun build(): String
}