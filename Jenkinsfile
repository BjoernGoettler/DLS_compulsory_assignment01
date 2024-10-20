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
                sh 'git merge ${GIT_BRANCH}'
            }
        }
        stage('Build') {
            steps {
                sh 'docker compose build'
            }
        }
        stage('Publish') {
            steps {
                sh 'echo dotnet publish "LoggerService.csproj" -c $BUILD_CONFIGURATION -o /app/publish /p:UseAppHost=false'
            }
        }
    }
}