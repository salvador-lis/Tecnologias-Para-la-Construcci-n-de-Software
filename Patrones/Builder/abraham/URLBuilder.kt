

import java.lang.StringBuilder
import java.nio.charset.StandardCharsets
import jdk.internal.net.http.hpack.Encoder


class URLBuilder : urlInterface {
    private val protocol:String? = null
    private val hostname:String? = null
    private val port:String? = null
    private val paths: MutableMap<String, String>? = mutableMapOf()
    private val queryParams:String? = null


    override fun setProtocol(protocol: String){
        this.protocol? = protocol
    }

    override fun setHostName(hostname: String){
        this.hostname? = hostname
    }

    override fun setPort(port: String) {
        this.port? = port
    }

    override fun addPath(path: String) {
        this.paths.add(path)
    }

    override fun addQueryParam(key: String, value: String) {
        this.queryParams[key] = value
    }

    override fun build(): String {
        var url = kotlin.text.StringBuilder()

        this.protocol?.let {url.append("$protocol://")}
        this.hostname?.let { url.append(hostname)}
        this.port?.let { url.append("$port:") }

        if (this.paths.isNotEmpty()){
            this.paths.forEach {path -> url.append("/$path")}
        }
        if (this.queryParams.isEmpty()){
            url.append("?")
            val queryString = this.queryParams.entries.joinToString("&") {
                "${it.key}=${it.value}"
            }
            url.append(queryString)
        }
        return url.toString()
    }

    fun reset(): URLBuilder {
        this.protocol? = null
        this.hostname? = null
        this.port? = null
        this.paths? = null
        this.queryParams? = null
    }

    fun encode(value: String) = Encoder(value, StandardCharsets.UTF_8)
}