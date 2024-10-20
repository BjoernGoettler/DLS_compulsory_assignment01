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
        },
        stage('Build') {
            steps {
                sh 'dotnet restore LoggerService/LoggerService.csproj'
            }
        }
    }
}