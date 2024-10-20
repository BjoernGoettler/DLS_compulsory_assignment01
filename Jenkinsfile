pipeline {
    agent any
    triggers {
        pollSCM('* * * * *')
    }
    stages {
        stage('Git merge') {
            steps {
                sh 'git fetch --all'
                sh 'git checkout main'
                sh 'git pull'
                sh 'git merge origin/${GIT_BRANCH}'
            }
        }
        stage('Build') {
            steps {
                sh 'echo dotnet restore LoggerService/LoggerService.csproj'
                sh 'echo dotnet build "LoggerService.csproj" -c $BUILD_CONFIGURATION -o /app/build'
            }
        }
        stage('Publish') {
            steps {
                sh 'echo dotnet publish "LoggerService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false'
            }
        }
    }
}