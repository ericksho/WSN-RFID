class CreateAlertas < ActiveRecord::Migration
  def change
    create_table :alertas do |t|
      t.boolean :desconectada

      t.timestamps
    end
  end
end
