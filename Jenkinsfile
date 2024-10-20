pipeline {
    agent any
    triggers {
        pollSCM('* * * * *')
    }
    stages {
        stage('Git merge') {
            steps {
                sh 'git fetch --all'
                sh 'git merge origin/main}'
            }
        }
        stage('Build') {
            steps {
                sh 'docker compose build'
            }
        }
        stage('Publish') {
            steps {
                withCredentials([usernamePassword(CredentialsI: 'DockerHub',usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD')]) {
                    sh 'docker login -u $USERNAME -p $PASSWORD'
                    sh 'docker compose push'
                }
            }
        }
    }
}