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
        stage('Build') {
            steps {
                sh 'echo dotnet restore LoggerService/LoggerService.csproj'
                sh 'dotnet build "LoggerService.csproj" -c $BUILD_CONFIGURATION -o /app/build'
            }
        }
    }
}