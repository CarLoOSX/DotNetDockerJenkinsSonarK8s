pipeline 
{
    agent any
    stages 
    {
        stage('Build') 
        {
            steps 
            {
		echo '.: Going to the Project\'s Directory :.'
    			
		echo '.: Starting Publishing to SonarQube :.'	
				
		echo '.: Finished publishing SonarQube :.'
 
		echo '.: Exiting the Project\'s Directory :.'
				
        }
        stage('Test') {
            steps {
                echo '.: Testing :.'
	
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
                    
            }
        } 
    }
}