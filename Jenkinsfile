pipeline {
    agent any
    triggers {
        pollSCM('* * * * *')
    }
    stages {
        stage('Greet') {
            steps {
                sh 'echo hello!'
            }
        }
    }
}