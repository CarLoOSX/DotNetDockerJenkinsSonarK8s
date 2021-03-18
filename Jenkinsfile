pipeline 
{
    agent any
    stages 
    {
        stage('Build') 
        {
              echo '.: Going to the Project\'s Directory :.'
 
				dir('src/HelloWorldMicroService') {
    			
				    echo '.: Starting Publishing to SonarQube :.'
				
				    sh "${env.sonarScanner} begin /k:\"HelloWorld\" /d:sonar.host.url=\"http://whiskicasa.tplinkdns.com:9000\" /d:sonar.login=\"3395a08ed67a6c345690b81722f09bec7f12b6bf\""
				
				    sh "${env.dotnet} clean"
				
				    sh "${env.dotnet} build"
				
				    sh "${env.sonarScanner} end /d:sonar.login=\"3395a08ed67a6c345690b81722f09bec7f12b6bf\""
				
				    echo '.: Finished publishing SonarQube :.'
 
				    echo '.: Exiting the Project\'s Directory :.'
				
        }
         stage('Deploy') {
            steps {
                    echo '.: Creating Docker Image (Dotnet) :.'
    
                    sh "${env.docker} build -t carloosx/aspnethelloworld ."
    
                    echo '.: Pushing new image to docker hub :.'
    
                    sh "${env.docker} login"
                    
                    sh "${env.docker} push carloosx/aspnethelloworld"
    
                    echo '.: Image uploaded to docker hub :.'
            }
        }
        stage('Deploy') {
            steps {
                    echo '.: Creating Docker Image (Dotnet) :.'

                    echo '.: Pushing new image to docker hub :.'
    
                    echo '.: Image uploaded to docker hub :.'
            }
        }
         stage('Orchestrate') {
            steps {
                    echo '.: Deploying to kubernetes :.'
                    
                    echo "------------${BUILD_NUMBER}---------"
                    
                     sh "sed -ie \"s/BUILDNUMBER/${BUILD_NUMBER}/g\" Deployment.yml"
                    
                    sh "${env.kubectl} apply -f Deployment.yml"

                    sh "sed -ie \"s/BUILDNUMBER/${BUILD_NUMBER}/g\" Service.yml"
   
                    sh "${env.kubectl} apply -f Service.yml"
            }
        } 
    }
}