# Azure 運用トレーニング

## 概要

このトレーニングは、(株)オルターブースが主催する Azure 運用 トレーニングです。  
Azure の PaaS を使ったシステム運用ができるための足がかりを得ることを目指します。

## 参加者について

- Web アプリケーション運用に携わっている方
- Azure を使いこなすことに興味のある方

## 準備

本ハンズオンを実施するには、事前に下記の準備を完了している必要があります。

### 参加者の準備

- 事前学習

  ハンズオンをスムーズに進めるために、下記 Microsoft Learn の事前学習をお願いします。

  - 〇〇〇〇〇
    - 概要 : 〇〇〇〇
    - キーワード : 〇〇〇〇
    - 目安時間 : 〇〇 分
  - 〇〇〇〇〇
    - 概要 : 〇〇〇〇
    - キーワード : 〇〇〇〇
    - 目安時間 : 〇〇 分

### 弊社の準備

- `〇〇〇〇〇` team に弊社のハンズオン担当者を追加してください
- ハンズオン参加者の GitHub アカウント名を収集してください
- 参加者が使用するリポジトリについて、ハンズオンに使用する Organization に、テンプレートリポジトリから Private リポジトリを作成してください（例：`hol-12factor-2023XXyy`）

- 参加者用リポジトリに参加者を READ 権限で招待してください
  - 手順 : Settings > Collaborators and teams > Add people
- Zoom 会議 URL を発行してください
- ハンズオン参加者に GitHub リポジトリおよび Zoom の URL を案内してください

## アジェンダ

| プログラム         | 時間(目安)       | 場所   |
| :----------------- | :--------------- | :----- |
| 接続確認           | 開始前の 15 分間 | Zoom   |
| 座学および質疑応答 | 約 50 分間       | Zoom   |
| 休憩               | 10 分間          | -      |
| ハンズオン説明     | 10 分間          | Zoom   |
| ハンズオン実施     | 約 150 分間      | GitHub |
| 振り返り           | 15 分間          | Zoom   |

## 座学

Zoom にて実施します。

## ハンズオン

以下の手順に従ってハンズオンを進めてください。

0. [構築する環境の全体像を理解する](./docs/00_learning-environment.md)
1. [ハンズオン環境を準備する](./docs/01_setup-training-environment.md)
2. [シークレットをセキュアに管理する](./docs/02_securely-managing-secrets-with-key-vault.md)
3. [アプリケーションの正常性をチェックする](./docs/03_ensuring-application-health-with-health-checks.md)
4. [Azure Monitor ログ を使用してログを収集する](./docs/04_collecting-logs-with-azure-monitor-logs.md)
5. [Application Insights を使用してアプリケーションを監視する](./docs/05_monitoring-applications-with-application-insights.md)
6. [アラートを使用してメトリックの異常を通知する](./docs/06_detecting-application-issues-with-alerts.md)
7. [ダッシュボードを使った効率的なモニタリング](./docs/07_efficient-monitoring-with-dashboards.md)

## ハンズオン完了後

本ハンズオンで Azure リソースを作成した場合、完了後不要になったリソースは忘れずに削除するようにしましょう。
