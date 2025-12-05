// 

fun main(){
    val userID = 5
    val urlbuilder = URLBuilder()

    urlbuilder.setProtocol("http")
    urlbuilder.setHostName("api.example.com")
    urlbuilder.setPort("8000")
    urlbuilder.addPath("users")
    urlbuilder.addPath(userID.toString())
    
    val url = URLBuilder().build()
}