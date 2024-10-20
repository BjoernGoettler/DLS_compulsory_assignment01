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
                withCredentials([usernamePassword(CredentialsId: '46bf83a0-5188-43e1-9e61-370bd97ead34',usernameVariable: 'USERNAME', passwordVariable: 'PASSWORD')]) {
                    sh 'docker login -u $USERNAME -p $PASSWORD'
                    sh 'docker compose push'
                }
            }
        }
    }
}